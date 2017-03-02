#include "ddrgame.h"
#include <sensor.h>
#include <time.h>
#include <dlog.h>

int curStage = 0;

char *stageArr[] = { "eastArr.png", "northArr.png", "southArr.png", "westArr.png" };
int stage[4] = {0,};
char stages[4] = {0,};
int endStage = 3;

typedef struct appdata {
   Evas_Object *win;
   Evas_Object *conform;
   Evas_Object *label0;
   Evas_Object *label1;
   Evas_Object *label2;
   Evas_Object *btn;
   Evas_Object *img;
   Evas_Object *list;
   Eina_List *data_list;

} appdata_s;
Evas_Object *curimg;
Evas_Object *box;

typedef struct {
	int id;
	Evas_Object *img;
}itemdata_s;

itemdata_s *currSt;


typedef struct _sensor_info {
   sensor_h sensor;
   /**< Sensor handle */
   sensor_listener_h sensor_listener;
} sensorinfo;

static sensorinfo sensor_info;

float value[4] = {0.f, 0.f, 0.f, 0.f};

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
   ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
   appdata_s *ad = data;
   /* Let window go to hide state. */
   elm_win_lower(ad->win);
}

static void
show_is_supported(appdata_s *ad) {
   char buf[PATH_MAX];
   bool is_supported = false;
   sensor_is_supported(SENSOR_ACCELEROMETER, &is_supported);
   sprintf(buf, "Acceleration Sensor is %s", is_supported ? "supported" : "not supported");     elm_object_text_set(ad->label0, buf);
}

static void
my_box_pack(Evas_Object *box, Evas_Object *child,
                        double h_weight, double v_weight, double h_align, double v_align)
{
      {
           evas_object_size_hint_weight_set(child, h_weight, v_weight);
           evas_object_size_hint_align_set(child, h_align, v_align);
           evas_object_show(child);
           elm_object_content_set(box, child);
       }
       elm_box_pack_end(box,child);
       evas_object_show(child);

}


static float
get_absolute_max(float value1, float value2) {
   float v1 = value1 > 0.f ? value1 : -value1;
   float v2 = value2 > 0.f ? value2 : -value2;
   float result = v1 > v2 ? v1 : v2;
   return result;
}

static void my_rot_state(void *user_data, int state){
   appdata_s *ad = (appdata_s*)user_data;
   char buf[PATH_MAX];
   sprintf(buf, "STATE: %d, %s", state,
         (state == 1) ? "TOP" : (state == -1) ? "BOTTOM" : "NORMAL");

   //state function to make the function. To get gesture will be connected.

   elm_object_text_set(ad->btn, buf);

//   if(state == itemdata->id){
//	   curStage++;
//	   removeStage();
//   }

   return;
}

static void
_new_sensor_value(sensor_h sensor, sensor_event_s *sensor_data, void *user_data)
{
   if( sensor_data->value_count < 3 )
      return;

   char buf[PATH_MAX];
   appdata_s *ad = (appdata_s*)user_data;
   sprintf(buf, "Value - X : %0.1f / Y : %0.1f / Z : %0.1f",
         sensor_data->values[0], sensor_data->values[1], sensor_data->values[2]);

   elm_object_text_set(ad->label1, buf);
   my_rot_state(ad, sensor_data->values[3]);

   for(int i=0; i < 3; i++)
      value[i] = get_absolute_max(value[i], sensor_data->values[i]);
   sprintf(buf, "Max - X: %0.1f / Y: %0.1f / Z: %0.1f",
         value[0], value[1], value[2]);
   elm_object_text_set(ad->label2, buf);
}

/* Button click event function */
static void btn_clicked(void *data, Evas_Object *obj, void *event_info) {
   for(int i=0; i < 3; i++)
      value[i] = 0.f;
}

static void start_acceleration_sensor(appdata_s *ad) {
   sensor_error_e err = SENSOR_ERROR_NONE;
   sensor_get_default_sensor(SENSOR_ACCELEROMETER, &sensor_info.sensor);
   err = sensor_create_listener(sensor_info.sensor, &sensor_info.sensor_listener);
   sensor_listener_set_event_cb(sensor_info.sensor_listener, 100, _new_sensor_value, ad);
   sensor_listener_start(sensor_info.sensor_listener);
}

// Get full path of source file
static inline const char*
get_resource_path(const char *file_path)
{
   static char absolute_path[PATH_MAX] = {'\0'};

   static char *res_path_buff = NULL;
   if (res_path_buff == NULL) res_path_buff = app_get_resource_path();

   snprintf(absolute_path, PATH_MAX, "%s%s", res_path_buff, file_path);
   return absolute_path;
}

static void stageInit(int *stage){

	srand(time(NULL));
	for(int i = 0; i < 4; i++){
		stage[i] = rand() % 4;
	}
}

static void makeStage(appdata_s *ad,int stage[],Evas_Object *iNbox,char **stageArr){
	//make all stages
	for(int i = 0 ;i <4; i++){
		itemdata_s *idata = calloc(1,sizeof(itemdata_s));
		idata->id = i;
		idata->img = elm_image_add(ad->conform);
		const char *res_path=get_resource_path(stageArr[stage[i]]);
		elm_image_file_set(idata->img, res_path,NULL);
		evas_object_size_hint_min_set(idata->img,170,170);
		evas_object_size_hint_max_set(idata->img,170,170);
		my_box_pack(iNbox, idata->img, 1.0, 0.0, -1.0, -1.0);
		ad->data_list = eina_list_append(ad->data_list,idata);
	}
//	itemdata_s *itemdata = eina_list_nth(ad->data_list, i); //item select nth
}

static void showStage(appdata_s *ad,int stage[],Evas_Object *box, char **stageArr,int curStage){
	//show the current stage
	currSt = eina_list_nth(ad->data_list, curStage); //item select nth
	currSt->img = elm_image_add(ad->conform);
	const char *res_path=get_resource_path(stageArr[stage[currSt->id]]);
	elm_image_file_set(currSt->img, res_path,NULL);
	evas_object_size_hint_min_set(currSt->img,170,170);
	evas_object_size_hint_max_set(currSt->img,170,170);
	my_box_pack(box, currSt->img, 1.0, 0.0, -1.0, -1.0);
}

static void nextStage(void *data, Evas_Object *obj, void *event_info) {
	if(curStage > endStage)
		return;
	curStage++;
	const char *res_path=get_resource_path(stageArr[stage[curStage]]);
	elm_image_file_set(currSt->img, res_path,NULL);
	evas_object_size_hint_min_set(currSt->img,170,170);
	evas_object_size_hint_max_set(currSt->img,170,170);
}



static void
create_base_gui(appdata_s *ad)
{

   /* Window */
   ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
   elm_win_autodel_set(ad->win, EINA_TRUE);

   if (elm_win_wm_rotation_supported_get(ad->win)) {
      int rots[4] = { 0, 90, 180, 270 };
      elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
   }

   evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
   eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

   /* Conformant */
   ad->conform = elm_conformant_add(ad->win);
   elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
   elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
   evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   elm_win_resize_object_add(ad->win, ad->conform);
   evas_object_show(ad->conform);
    {
        Evas_Object *btn;

        box = elm_box_add(ad->win);
        evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
        elm_object_content_set(ad->conform, box);
        evas_object_show(box);
        {
           /* child object - indent to how relationship */



           /* Label-0 */
           ad->label0 = elm_label_add(box);
           elm_object_text_set(ad->label0, "Msg - ");
           my_box_pack(box, ad->label0, 1.0, 0.0, -1.0, 0.0);
            /* Label-1 */
           ad->label1 = elm_label_add(box);
           elm_object_text_set(ad->label1, "Value - ");
           my_box_pack(box, ad->label1, 1.0, 0.0, -1.0, 0.0);


           Evas_Object *iNbox = elm_box_add(ad->win);
           evas_object_size_hint_weight_set(iNbox, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
           elm_box_horizontal_set(iNbox,EINA_TRUE);
           //created box horizontal
           elm_object_content_set(box, iNbox);
           my_box_pack(box,iNbox,1.0,0.0,-1.0,0.0);

//           //           image add
//           ad->img = elm_image_add(ad->conform);
//           const char* file = "compass-web.png";
//           const char *res_path=get_resource_path(file);
//
//           elm_image_file_set(ad->img, res_path,NULL);
//           evas_object_size_hint_min_set(ad->img,200,200);
//           evas_object_size_hint_max_set(ad->img,200,200);
//           my_box_pack(iNbox, ad->img, 1.0, 0.0, -1.0, -1.0);
//
//           Evas_Object *img2 = elm_image_add(ad->conform);
//
//           elm_image_file_set(img2, res_path,NULL);
//           evas_object_size_hint_min_set(img2,200,200);
//           evas_object_size_hint_max_set(img2,200,200);
//           my_box_pack(iNbox, img2, 1.0, 0.0, -1.0, -1.0);


           //make stages 5
           stageInit(stage);


           ad->list = elm_list_add(ad->conform);

           makeStage(ad,stage,iNbox,stageArr);



           showStage(ad,stage,box,stageArr,curStage);


           //이미지 제거


           /* Button */
           Evas_Object *btn = elm_button_add(ad->conform);

           elm_object_text_set(btn, "NEXT STAGE");
           evas_object_smart_callback_add(btn, "clicked", nextStage, ad);
           my_box_pack(box, btn, 1.0, 0.0, -1.0, -1.0);
           /* My Button */
           ad->btn = elm_button_add(ad->conform);
         elm_object_text_set(ad->btn, "INIT");
         // evas_object_smart_callback_add(btn, "clicked", btn_clicked, ad);
         my_box_pack(box, ad->btn, 1.0, 0.0, -1.0, -1.0);
           /* Label-2 */
           ad->label2 = elm_label_add(ad->conform);
           elm_object_text_set(ad->label2, "Max - ");
           my_box_pack(box, ad->label2, 1.0, 1.0, -1.0, -1.0);
        }
    }
    /* Show window after base gui is set up */
    evas_object_show(ad->win);
    show_is_supported(ad);
    start_acceleration_sensor(ad);
}

static bool
app_create(void *data)
{
   /* Hook to take necessary actions before main event loop starts
      Initialize UI resources and application's data
      If this function returns true, the main loop of application starts
      If this function returns false, the application is terminated */
   appdata_s *ad = data;

   create_base_gui(ad);

   return true;
}

static void
app_control(app_control_h app_control, void *data)
{
   /* Handle the launch request. */
}

static void
app_pause(void *data)
{
   /* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
   /* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
   /* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
   /*APP_EVENT_LANGUAGE_CHANGED*/
   char *locale = NULL;
   system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
   elm_language_set(locale);
   free(locale);
   return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
   /*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
   return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
   /*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
   /*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
   /*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
   appdata_s ad = {0,};
   int ret = 0;

   ui_app_lifecycle_callback_s event_callback = {0,};
   app_event_handler_h handlers[5] = {NULL, };

   event_callback.create = app_create;
   event_callback.terminate = app_terminate;
   event_callback.pause = app_pause;
   event_callback.resume = app_resume;
   event_callback.app_control = app_control;

   ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
   ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

   ret = ui_app_main(argc, argv, &event_callback, &ad);
   if (ret != APP_ERROR_NONE) {
      dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
   }

   return ret;
}
