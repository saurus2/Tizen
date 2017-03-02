S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: ddrgame
PID: 12558
Date: 2016-12-03 21:34:38+0900
Executable File Path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x9bedd900

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37a9564, esi = 0xbfaf08c8
ebp = 0xbfaf0318, esp = 0xbfaf02d0
eax = 0x3a1cd0e7, ebx = 0xb37a9580
ecx = 0x00000005, edx = 0x800174bb
eip = 0xb37a7571

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         7 KB
Cached:     165780 KB
VmPeak:     115336 KB
VmSize:     115336 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20808 KB
VmRSS:       20808 KB
VmData:      51384 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33452 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12558 TID = 12558
12558 12559 12648 12649 12656 

Maps Information
b2c68000 b2c72000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c78000 b2c84000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c85000 b2ca6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cab000 b2cac000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cad000 b2cb2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cb3000 b2cb4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2cb5000 b2cb7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cb8000 b2cc4000 r-xp /usr/lib/libdrm.so.2.4.0
b2cc5000 b2cc8000 r-xp /usr/lib/libdri2.so.0.0.0
b2cc9000 b2cd3000 r-xp /usr/lib/libtbm.so.1.0.0
b2cd4000 b2ce9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cea000 b2cfc000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34fe000 b3507000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3508000 b3511000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3512000 b3524000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b352b000 b352c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b352d000 b352e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b352f000 b3532000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3533000 b3536000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b363e000 b3644000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3645000 b3789000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3799000 b379b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b379c000 b379d000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b379e000 b37a4000 r-xp /usr/lib/libcapi-system-sensor.so.0.2.0
b37a5000 b37a9000 r-xp /opt/usr/apps/org.example.ddrgame/bin/ddrgame
b37ab000 b37e4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41e7000 b41f2000 r-xp /lib/libnss_files-2.20-2014.11.so
b41f4000 b41ff000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4201000 b4218000 r-xp /lib/libnsl-2.20-2014.11.so
b421c000 b4224000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4226000 b424a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b424b000 b424c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b424d000 b4250000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4251000 b4258000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4259000 b4263000 r-xp /usr/lib/libsensord-share.so
b4264000 b4280000 r-xp /usr/lib/libsensor.so.1.2.0
b4282000 b428b000 r-xp /usr/lib/libappcore-common.so.1.1
b428e000 b4290000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42a5000 b42a7000 r-xp /usr/lib/libXau.so.6.0.0
b42a8000 b42ca000 r-xp /usr/lib/libxcb.so.1.1.0
b42cc000 b42d5000 r-xp /lib/libcrypt-2.20-2014.11.so
b42fe000 b4300000 r-xp /usr/lib/libiri.so
b4301000 b4327000 r-xp /lib/libexpat.so.1.5.2
b4329000 b4394000 r-xp /usr/lib/libssl.so.1.0.0
b439a000 b43a6000 r-xp /usr/lib/libethumb.so.1.13.0
b43a7000 b43ab000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ac000 b45fd000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b78000 b5b88000 r-xp /usr/lib/libXi.so.6.1.0
b5b89000 b5b8b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b8c000 b5b92000 r-xp /usr/lib/libXtst.so.6.1.0
b5b93000 b5b9d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b9e000 b5ba7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5ba9000 b5bab000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bac000 b5bb1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bb2000 b5bc4000 r-xp /usr/lib/libXext.so.6.4.0
b5bc5000 b5bc7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc8000 b5bca000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bcc000 b5d0e000 r-xp /usr/lib/libX11.so.6.3.0
b5d12000 b5d1c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d1d000 b5d33000 r-xp /usr/lib/libudev.so.1.6.0
b5d36000 b5d3a000 r-xp /lib/libattr.so.1.1.0
b5d3b000 b5d6a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d6c000 b5d72000 r-xp /usr/lib/libffi.so.6.0.2
b5d73000 b5d96000 r-xp /lib/libz.so.1.2.8
b5d97000 b5d9a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d9b000 b5ef7000 r-xp /usr/lib/libxml2.so.2.9.2
b5efd000 b5fe4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ff1000 b5ff4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ff5000 b6017000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6018000 b602c000 r-xp /lib/libresolv-2.20-2014.11.so
b6030000 b6054000 r-xp /usr/lib/liblzma.so.5.0.3
b6055000 b6057000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6059000 b6063000 r-xp /usr/lib/libembryo.so.1.13.0
b6064000 b608d000 r-xp /usr/lib/libpng12.so.0.50.0
b608e000 b60d7000 r-xp /usr/lib/libjpeg.so.8.0.2
b60e8000 b60ef000 r-xp /lib/librt-2.20-2014.11.so
b60f1000 b6110000 r-xp /usr/lib/libector.so.1.13.0
b6113000 b6140000 r-xp /usr/lib/liblua-5.1.so
b6141000 b61d1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61d5000 b6213000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6214000 b622a000 r-xp /usr/lib/libfribidi.so.0.3.1
b622b000 b6284000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6287000 b62d2000 r-xp /lib/libm-2.20-2014.11.so
b62d4000 b62e6000 r-xp /usr/lib/libeio.so.1.13.0
b62e7000 b62ea000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62eb000 b62f1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62f2000 b6315000 r-xp /usr/lib/libefreet.so.1.13.0
b6318000 b6343000 r-xp /usr/lib/libeldbus.so.1.13.0
b6344000 b6378000 r-xp /usr/lib/libecore_con.so.1.13.0
b637a000 b6383000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6384000 b638d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b638e000 b63a1000 r-xp /usr/lib/libeo.so.1.13.0
b63a3000 b63b6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63b7000 b63be000 r-xp /usr/lib/libecore_file.so.1.13.0
b63bf000 b63e2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63e3000 b640f000 r-xp /usr/lib/libeet.so.1.13.0
b6418000 b6483000 r-xp /usr/lib/libeina.so.1.13.0
b6486000 b649d000 r-xp /usr/lib/libefl.so.1.13.0
b649f000 b6606000 r-xp /usr/lib/libicuuc.so.51.1
b6614000 b6820000 r-xp /usr/lib/libicui18n.so.51.1
b6828000 b6877000 r-xp /usr/lib/libecore_x.so.1.13.0
b6879000 b6893000 r-xp /lib/libgcc_s-4.9.so.1
b6895000 b6899000 r-xp /lib/libcap.so.2.21
b689a000 b68e0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68e1000 b68e8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68ea000 b693c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b693e000 b6ac9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ace000 b6b9c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b9f000 b6ba3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6ba4000 b6bb3000 r-xp /usr/lib/libvconf.so.0.2.45
b6bb4000 b6bb7000 r-xp /usr/lib/libvasum.so.0.3.1
b6bb8000 b6bbb000 r-xp /usr/lib/libttrace.so.1.1
b6bbd000 b6bc1000 r-xp /usr/lib/libiniparser.so.0
b6bc2000 b6bf2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bf3000 b6bfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bfd000 b6c22000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c23000 b6c33000 r-xp /usr/lib/libunwind.so.8.0.1
b6c3d000 b6deb000 r-xp /lib/libc-2.20-2014.11.so
b6df3000 b6f36000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f38000 b6f90000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f91000 b6fc5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fc8000 b709c000 r-xp /usr/lib/libedje.so.1.13.0
b709f000 b70cb000 r-xp /usr/lib/libecore.so.1.13.0
b70dc000 b7302000 r-xp /usr/lib/libevas.so.1.13.0
b732a000 b7342000 r-xp /lib/libpthread-2.20-2014.11.so
b7346000 b76c0000 r-xp /usr/lib/libelementary.so.1.13.0
b76e0000 b76e4000 r-xp /usr/lib/libsmack.so.1.0.0
b76e5000 b76ee000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ef000 b76f2000 r-xp /usr/lib/libdlog.so.0.0.0
b76f3000 b76f8000 r-xp /usr/lib/libbundle.so.0.1.22
b76f9000 b76fc000 r-xp /lib/libdl-2.20-2014.11.so
b76fe000 b7723000 r-xp /usr/lib/libaul.so.0.1.0
b7726000 b7728000 r-xp /usr/lib/libappsvc.so.0.1.0
b7729000 b772e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b772f000 b7736000 r-xp /usr/lib/libappcore-efl.so.1.1
b7738000 b773d000 r-xp /usr/lib/libsys-assert.so
b7740000 b7741000 r-xp [vdso]
b7741000 b7763000 r-xp /lib/ld-2.20-2014.11.so
b7765000 b776d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12558)
Call Stack Count: 21
 0: nextStage + 0x51 (0xb37a7571) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x2571
 1: (0xb7165116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb639c319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6399d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71679e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7418404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb704bf39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7052a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb704cfdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb704d4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb704d68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70b2702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70ac055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70b51b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70b5587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb750e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7732dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb772bc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: main + 0x2aa (0xb37a66da) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x16da
19: my_box_pack + 0xb8 (0xb7767148) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0xb7767148
20: __libc_start_main + 0xde (0xb6c54e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.ddrgame
Package ID : org.example.ddrgame
Version: 1.0.0
Package Type: tpk
App Name: ddrgame
App ID: org.example.ddrgame
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
E( 2908): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
12-03 21:34:24.680+0900 D/APP_CORE( 2908): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
12-03 21:34:24.680+0900 D/APP_CORE( 2908): appcore-efl.c: __do_app(607) > [APP 2908] RESUME
12-03 21:34:24.680+0900 I/CAPI_APPFW_APPLICATION( 2908): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
12-03 21:34:24.680+0900 E/cluster-home( 2908): homescreen.cpp: OnResume(66) >  app resume
12-03 21:34:24.680+0900 D/cluster-home( 2908): widget-data-provider.cpp: SetBoxVisibility(1543) >  
12-03 21:34:24.680+0900 D/cluster-home( 2908): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
12-03 21:34:24.680+0900 D/WIDGET_VIEWER( 2908): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
12-03 21:34:24.680+0900 D/cluster-home( 2908): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
12-03 21:34:24.680+0900 D/cluster-home( 2908): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
12-03 21:34:24.680+0900 D/cluster-view( 2908): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
12-03 21:34:24.680+0900 D/cluster-view( 2908): homescreen-view-manager.cpp: AppResume(910) >  END
12-03 21:34:24.680+0900 D/cluster-view( 2908): custom-cluster-impl.cpp: AppResumed(1380) >  Cancel pick operation
12-03 21:34:24.680+0900 D/cluster-view( 2908): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
12-03 21:34:24.680+0900 D/cluster-view( 2908): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
12-03 21:34:24.680+0900 D/cluster-view( 2908): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
12-03 21:34:24.680+0900 D/cluster-view( 2908): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
12-03 21:34:24.680+0900 D/test-log( 2908): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
12-03 21:34:24.680+0900 D/test-log( 2908): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
12-03 21:34:24.680+0900 D/cluster-view( 2908): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
12-03 21:34:24.680+0900 D/cluster-home( 2908): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
12-03 21:34:24.680+0900 D/cluster-view( 2908): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
12-03 21:34:24.680+0900 D/cluster-view( 2908): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
12-03 21:34:24.680+0900 D/LAUNCH  ( 2908): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
12-03 21:34:24.680+0900 D/LAUNCH  ( 2908): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
12-03 21:34:24.680+0900 D/APP_CORE( 2908): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
12-03 21:34:24.680+0900 E/APP_CORE( 2908): appcore-efl.c: __trm_app_info_send_socket(242) > access
12-03 21:34:24.680+0900 E/EFL     ( 2803): eo<2803> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
12-03 21:34:24.690+0900 I/TIZEN_N_SOUND_MANAGER( 2992): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
12-03 21:34:24.690+0900 E/TIZEN_N_SOUND_MANAGER( 2992): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
12-03 21:34:24.690+0900 I/TIZEN_N_SOUND_MANAGER( 2992): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
12-03 21:34:24.690+0900 E/TIZEN_N_SOUND_MANAGER( 2992): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
12-03 21:34:24.690+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 15
12-03 21:34:24.690+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
12-03 21:34:24.690+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
12-03 21:34:24.690+0900 D/AUL_AMD ( 2802): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2908 is org.tizen.homescreen
12-03 21:34:24.690+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2908 : 0
12-03 21:34:24.700+0900 D/DATA_PROVIDER_MASTER( 2962): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2908 is resumed
12-03 21:34:24.700+0900 D/DATA_PROVIDER_MASTER( 2962): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
12-03 21:34:24.700+0900 E/DATA_PROVIDER_MASTER( 2962): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
12-03 21:34:24.700+0900 D/AUL     ( 2992): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
12-03 21:34:24.700+0900 I/CAPI_WIDGET_APPLICATION( 3053): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
12-03 21:34:24.700+0900 I/CAPI_WIDGET_APPLICATION( 3053): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
12-03 21:34:24.700+0900 W/AUL     ( 3053): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3053, appid: org.tizen.calendar.widget, status: fg
12-03 21:34:24.700+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3053
12-03 21:34:24.700+0900 D/RESOURCED( 2896): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3053, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
12-03 21:34:24.700+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3053
12-03 21:34:24.780+0900 D/RESOURCED( 2896): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3053, appname = org.tizen.calendar.widget
12-03 21:34:24.780+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3053
12-03 21:34:24.780+0900 I/RESOURCED( 2896): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
12-03 21:34:24.780+0900 I/RESOURCED( 2896): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
12-03 21:34:24.910+0900 D/cluster-view( 2908): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
12-03 21:34:24.910+0900 D/cluster-view( 2908): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
12-03 21:34:24.910+0900 D/cluster-view( 2908): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
12-03 21:34:24.910+0900 D/test-log( 2908): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
12-03 21:34:24.910+0900 D/test-log( 2908): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
12-03 21:34:24.910+0900 D/cluster-view( 2908): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
12-03 21:34:24.910+0900 D/cluster-home( 2908): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
12-03 21:34:26.330+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 21:34:26.330+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 21:34:26.330+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.330+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.340+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
12-03 21:34:26.340+0900 D/AUL     ( 2802): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 12642, pid = 12644
12-03 21:34:26.340+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.340+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.340+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
12-03 21:34:26.340+0900 E/AUL_AMD ( 2802): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
12-03 21:34:26.340+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2233) > caller pid : 12644
12-03 21:34:26.340+0900 E/AUL_AMD ( 2802): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
12-03 21:34:26.340+0900 W/AUL_AMD ( 2802): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 21:34:26.340+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2648) > process_pool: false
12-03 21:34:26.340+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 21:34:26.340+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 21:34:26.340+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 21:34:26.340+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 21:34:26.340+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 21:34:26.340+0900 D/AUL     ( 2802): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 21:34:26.340+0900 W/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 21:34:26.340+0900 D/AUL     ( 2960): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12558, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 21:34:26.340+0900 W/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 21:34:26.340+0900 D/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 21:34:26.340+0900 D/RESOURCED( 2896): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 21:34:26.340+0900 D/RESOURCED( 2896): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 21:34:26.340+0900 E/RESOURCED( 2896): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 21:34:26.340+0900 D/AUL     (12558): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12559) is sent.
12-03 21:34:26.340+0900 D/AUL     (12558): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12559, signo: 10
12-03 21:34:26.340+0900 D/AUL     (12558): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3Njg0NjYvMzM4MjM5AA==##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMjY0NAA=##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 8
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 21:34:26.340+0900 D/AUL_PAD (12558): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 21:34:26.340+0900 I/CAPI_APPFW_APPLICATION(12558): app_main.c: ui_app_main(788) > app_efl_main
12-03 21:34:26.340+0900 D/LAUNCH  (12558): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 21:34:26.340+0900 D/APP_CORE(12558): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 21:34:26.340+0900 D/APP_CORE(12558): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 21:34:26.340+0900 D/APP_CORE(12558): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 21:34:26.360+0900 D/APP_CORE(12558): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 21:34:26.360+0900 D/AUL     (12558): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 21:34:26.360+0900 D/APP_CORE(12558): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb428b520
12-03 21:34:26.360+0900 D/LAUNCH  (12558): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 21:34:26.360+0900 I/CAPI_APPFW_APPLICATION(12558): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 21:34:26.420+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.420+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.420+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.420+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.430+0900 E/EFL     (12558): eo<12558> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 21:34:26.440+0900 D/LAUNCH  (12558): appcore-efl.c: __before_loop(1154) > [ddrgame:Application:create:done]
12-03 21:34:26.440+0900 E/E17     ( 2803): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
12-03 21:34:26.440+0900 D/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
12-03 21:34:26.440+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12558, appid: org.example.ddrgame
12-03 21:34:26.440+0900 D/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 21:34:26.440+0900 E/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 21:34:26.440+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2700) > add app group info
12-03 21:34:26.440+0900 E/AUL     ( 2802): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
12-03 21:34:26.440+0900 D/AUL_AMD ( 2802): amd_status.c: _status_add_app_info_list(427) > pid(12558) appid(org.example.ddrgame) pkgid(org.example.ddrgame) comp(uiapp)
12-03 21:34:26.440+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.ddrgame, 12558
12-03 21:34:26.440+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.ddrgame with pkgname
12-03 21:34:26.440+0900 E/RESOURCED( 2896): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.ddrgame
12-03 21:34:26.440+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(888) > available memory = 316
12-03 21:34:26.440+0900 D/APP_CORE(12558): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
12-03 21:34:26.440+0900 E/E17     ( 2803): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
12-03 21:34:26.480+0900 W/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12558
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore.c: __aul_handler(587) > [APP 12558]     AUL event: AUL_START
12-03 21:34:26.490+0900 I/APP_CORE(12558): appcore-efl.c: __do_app(496) > [APP 12558] Event: RESET State: CREATED
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore-efl.c: __do_app(527) > [APP 12558] RESET
12-03 21:34:26.490+0900 D/LAUNCH  (12558): appcore-efl.c: __do_app(529) > [ddrgame:Application:reset:start]
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
12-03 21:34:26.490+0900 I/CAPI_APPFW_APPLICATION(12558): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
12-03 21:34:26.490+0900 D/AUL     (12558): service.c: __set_bundle(186) > __set_bundle
12-03 21:34:26.490+0900 D/LAUNCH  (12558): appcore-efl.c: __do_app(544) > [ddrgame:Application:reset:done]
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
12-03 21:34:26.490+0900 E/EFL     (12558): edje<12558> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
12-03 21:34:26.490+0900 E/EFL     (12558): By the power of Grayskull, your previous Embryo stack is now broken!
12-03 21:34:26.490+0900 E/EFL     (12558): edje<12558> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
12-03 21:34:26.490+0900 E/EFL     (12558): By the power of Grayskull, your previous Embryo stack is now broken!
12-03 21:34:26.490+0900 E/EFL     (12558): edje<12558> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
12-03 21:34:26.490+0900 E/EFL     (12558): By the power of Grayskull, your previous Embryo stack is now broken!
12-03 21:34:26.490+0900 E/EFL     (12558): edje<12558> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
12-03 21:34:26.490+0900 E/EFL     (12558): By the power of Grayskull, your previous Embryo stack is now broken!
12-03 21:34:26.490+0900 E/EFL     (12558): edje<12558> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
12-03 21:34:26.490+0900 E/EFL     (12558): By the power of Grayskull, your previous Embryo stack is now broken!
12-03 21:34:26.490+0900 E/EFL     ( 2803): eo<2803> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
12-03 21:34:26.490+0900 E/EFL     ( 2803): eo<2803> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
12-03 21:34:26.490+0900 D/INDICATOR( 2899): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
12-03 21:34:26.490+0900 D/INDICATOR( 2899): util.c: util_signal_emit_by_win(116) > emission bg.opaque
12-03 21:34:26.490+0900 D/INDICATOR( 2899): main.c: _rotate_window(229) > Indicator angle is 0 degree
12-03 21:34:26.490+0900 D/INDICATOR( 2899): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
12-03 21:34:26.490+0900 D/INDICATOR( 2899): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
12-03 21:34:26.490+0900 D/INDICATOR( 2899): main.c: _rotate_window(252) > port :: hide more icon
12-03 21:34:26.490+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 15
12-03 21:34:26.490+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.490+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 21:34:26.490+0900 D/AUL_AMD ( 2802): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12558 is org.example.ddrgame
12-03 21:34:26.490+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12558 : 0
12-03 21:34:26.490+0900 D/AUL     ( 2992): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
12-03 21:34:26.490+0900 W/APP_CORE(12558): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
12-03 21:34:26.490+0900 D/APP_CORE(12558): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
12-03 21:34:26.490+0900 D/AUL     (12558): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
12-03 21:34:26.490+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 34
12-03 21:34:26.750+0900 E/E17     ( 2803): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
12-03 21:34:26.750+0900 D/APP_CORE( 2908): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
12-03 21:34:26.750+0900 D/APP_CORE( 2908): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
12-03 21:34:26.750+0900 D/APP_CORE( 2908): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
12-03 21:34:26.750+0900 I/APP_CORE( 2908): appcore-efl.c: __do_app(496) > [APP 2908] Event: PAUSE State: RUNNING
12-03 21:34:26.750+0900 D/APP_CORE( 2908): appcore-efl.c: __do_app(565) > [APP 2908] PAUSE
12-03 21:34:26.750+0900 I/CAPI_APPFW_APPLICATION( 2908): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
12-03 21:34:26.750+0900 E/cluster-home( 2908): homescreen.cpp: OnPause(84) >  app pause
12-03 21:34:26.750+0900 D/cluster-view( 2908): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
12-03 21:34:26.750+0900 D/cluster-view( 2908): homescreen-view-manager.cpp: AppPause(923) >  END
12-03 21:34:26.750+0900 D/APP_CORE( 2908): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
12-03 21:34:26.750+0900 E/APP_CORE( 2908): appcore-efl.c: __trm_app_info_send_socket(242) > access
12-03 21:34:26.750+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(456) > pid(2908) status(4)
12-03 21:34:26.750+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(468) > pid(2908) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
12-03 21:34:26.750+0900 D/AUL     ( 2802): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
12-03 21:34:26.750+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2908, appid: org.tizen.homescreen, status: bg
12-03 21:34:26.750+0900 D/AUL_AMD ( 2802): amd_launch.c: __e17_status_handler(2891) > pid(12558) status(3)
12-03 21:34:26.750+0900 D/AUL_AMD ( 2802): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
12-03 21:34:26.770+0900 W/AUL_AMD ( 2802): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
12-03 21:34:26.770+0900 W/AUL_AMD ( 2802): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
12-03 21:34:26.770+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(456) > pid(12558) status(3)
12-03 21:34:26.770+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(468) > pid(12558) appid(org.example.ddrgame) pkgid(org.example.ddrgame) status(3)
12-03 21:34:26.770+0900 D/AUL     ( 2802): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.ddrgame
12-03 21:34:26.770+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12558, appid: org.example.ddrgame, status: fg
12-03 21:34:26.770+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12558
12-03 21:34:26.770+0900 D/RESOURCED( 2896): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12558, proc_name: org.example.ddrgame, cg_name: foreground, oom_score_adj: 200
12-03 21:34:26.770+0900 D/DATA_PROVIDER_MASTER( 2962): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2908 is paused
12-03 21:34:26.770+0900 D/DATA_PROVIDER_MASTER( 2962): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
12-03 21:34:26.770+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12558
12-03 21:34:26.770+0900 I/CAPI_WIDGET_APPLICATION( 3053): widget_app.c: __provider_pause_cb(294) > widget obj was paused
12-03 21:34:26.770+0900 I/CAPI_WIDGET_APPLICATION( 3053): widget_app.c: __check_status_for_cgroup(142) > enter background group
12-03 21:34:26.770+0900 W/AUL     ( 3053): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3053, appid: org.tizen.calendar.widget, status: bg
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
12-03 21:34:26.790+0900 I/APP_CORE(12558): appcore-efl.c: __do_app(496) > [APP 12558] Event: RESUME State: CREATED
12-03 21:34:26.790+0900 D/LAUNCH  (12558): appcore-efl.c: __do_app(597) > [ddrgame:Application:resume:start]
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
12-03 21:34:26.790+0900 D/APP_CORE(12558): appcore-efl.c: __do_app(607) > [APP 12558] RESUME
12-03 21:34:26.800+0900 I/APP_CORE(12558): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
12-03 21:34:26.800+0900 I/APP_CORE(12558): appcore-efl.c: __do_app(614) > [APP 12558] Initial Launching, call the resume_cb
12-03 21:34:26.800+0900 I/CAPI_APPFW_APPLICATION(12558): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
12-03 21:34:26.800+0900 D/LAUNCH  (12558): appcore-efl.c: __do_app(636) > [ddrgame:Application:resume:done]
12-03 21:34:26.800+0900 D/LAUNCH  (12558): appcore-efl.c: __do_app(638) > [ddrgame:Application:Launching:done]
12-03 21:34:26.800+0900 D/APP_CORE(12558): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
12-03 21:34:26.800+0900 E/APP_CORE(12558): appcore-efl.c: __trm_app_info_send_socket(242) > access
12-03 21:34:26.850+0900 D/RESOURCED( 2896): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12558, appname = org.example.ddrgame, pkgname = org.example.ddrgame
12-03 21:34:26.850+0900 D/RESOURCED( 2896): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12558, appname = org.example.ddrgame
12-03 21:34:26.850+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12558
12-03 21:34:26.850+0900 D/RESOURCED( 2896): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3053, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
12-03 21:34:26.850+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3053
12-03 21:34:26.850+0900 D/RESOURCED( 2896): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3053, appname = org.tizen.calendar.widget
12-03 21:34:26.850+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3053
12-03 21:34:26.850+0900 I/RESOURCED( 2896): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
12-03 21:34:26.850+0900 I/RESOURCED( 2896): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
12-03 21:34:26.980+0900 D/AUL_AMD ( 2802): amd_launch.c: __e17_status_handler(2910) > pid(12558) status(0)
12-03 21:34:26.990+0900 D/APP_CORE(12558): appcore.c: __prt_ltime(236) > [APP 12558] first idle after reset: 655 msec
12-03 21:34:27.000+0900 E/PKGMGR_SERVER(12592): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
12-03 21:34:27.000+0900 E/PKGMGR_SERVER(12592): pkgmgr-server.c: main(2265) > package manager server terminated.
12-03 21:34:27.450+0900 D/AUL_PAD ( 2960): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
12-03 21:34:27.450+0900 D/AUL_PAD (12654): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
12-03 21:34:27.450+0900 D/AUL_PAD ( 2960): sigchild.h: __send_app_launch_signal(131) > send launch signal done
12-03 21:34:27.460+0900 E/RESOURCED( 2896): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.836
12-03 21:34:27.950+0900 D/AUL_AMD ( 2802): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.ddrgame /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 21:34:27.950+0900 D/RUA     ( 2802): rua.c: rua_add_history(179) > rua_add_history start
12-03 21:34:27.960+0900 D/RUA     ( 2802): rua.c: rua_add_history(247) > rua_add_history ok
12-03 21:34:28.500+0900 D/AUL_PAD (12654): launchpad_loader.c: main(588) > sleeping 1 sec...
12-03 21:34:28.500+0900 D/AUL_PAD (12654): preload.h: __preload_init(52) > max_cmdline_size = 1053
12-03 21:34:28.500+0900 D/AUL_PAD (12654): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8eb0760
12-03 21:34:28.500+0900 D/AUL_PAD (12654): preload.h: __preload_init(69) > get pre-initialization function
12-03 21:34:28.500+0900 D/AUL_PAD (12654): preload.h: __preload_init(73) > get shutdown function
12-03 21:34:28.500+0900 D/AUL_PAD (12654): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8eb0a40
12-03 21:34:28.510+0900 D/AUL_PAD (12654): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8eb2640
12-03 21:34:28.510+0900 D/AUL_PAD (12654): preload.h: __preload_init(69) > get pre-initialization function
12-03 21:34:28.510+0900 D/AUL_PAD (12654): preload.h: __preload_init(73) > get shutdown function
12-03 21:34:28.510+0900 D/AUL_PAD (12654): preexec.h: __preexec_init(76) > preexec start
12-03 21:34:28.510+0900 D/AUL_PAD (12654): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
12-03 21:34:28.510+0900 D/AUL     (12654): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
12-03 21:34:28.510+0900 D/AUL     (12654): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
12-03 21:34:28.510+0900 D/AUL     (12654): process_pool.c: __connect_to_launchpad(132) > send(12654) : 4
12-03 21:34:28.510+0900 D/AUL     (12654): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
12-03 21:34:28.510+0900 D/AUL_PAD ( 2960): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12654
12-03 21:34:28.760+0900 D/AUL_PAD (12654): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
12-03 21:34:28.760+0900 D/AUL_PAD (12654): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
12-03 21:34:28.760+0900 D/AUL_PAD (12654): launchpad_loader.c: main(693) > [candidate] ecore handler add
12-03 21:34:28.760+0900 D/AUL_PAD (12654): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
12-03 21:34:29.410+0900 D/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(442) > pid(12462)
12-03 21:34:29.410+0900 W/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
12-03 21:34:29.410+0900 D/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(442) > pid(12462)
12-03 21:34:29.410+0900 W/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
12-03 21:34:31.720+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:31.780+0900 D/APP_CORE( 2908): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
12-03 21:34:31.780+0900 I/APP_CORE( 2908): appcore-efl.c: __do_app(496) > [APP 2908] Event: MEM_FLUSH State: PAUSED
12-03 21:34:31.780+0900 D/APP_CORE( 2908): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
12-03 21:34:31.780+0900 D/APP_CORE( 2908): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2908
12-03 21:34:31.780+0900 D/APP_CORE( 2908): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
12-03 21:34:31.780+0900 D/RESOURCED( 2896): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2908
12-03 21:34:32.480+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:33.360+0900 E/CAPI_NETWORK_WIFI( 2899): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
12-03 21:34:33.360+0900 E/INDICATOR( 2899): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
12-03 21:34:33.360+0900 E/INDICATOR( 2899): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
12-03 21:34:33.360+0900 E/INDICATOR( 2899): 
12-03 21:34:33.520+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
12-03 21:34:33.710+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:35.000+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:36.310+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:38.080+0900 D/PROCESSMGR( 2803): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x61411d 
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 21:34:38.220+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 21:34:38.220+0900 I/AUL_PAD ( 2960): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 12558 pgid = 12558
12-03 21:34:38.220+0900 I/AUL_PAD ( 2960): sigchild.h: __sigchild_action(142) > dead_pid(12558)
12-03 21:34:38.230+0900 E/EFL     ( 2803): eo<2803> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
12-03 21:34:38.230+0900 D/AUL_PAD ( 2960): sigchild.h: __send_app_dead_signal(90) > send dead signal done
12-03 21:34:38.230+0900 I/AUL_PAD ( 2960): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
12-03 21:34:38.230+0900 I/AUL_PAD ( 2960): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
12-03 21:34:38.230+0900 E/AUL_PAD ( 2960): launchpad.c: main(688) > error reading sigchld info
12-03 21:34:38.240+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 12558 is termianted
12-03 21:34:38.240+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
12-03 21:34:38.240+0900 W/AUL_AMD ( 2802): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 12558
12-03 21:34:38.240+0900 W/AUL_AMD ( 2802): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 12558
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_key.c: _unregister_key_event(179) > ===key stack===
12-03 21:34:38.240+0900 E/AUL_AMD ( 2802): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.ddrgame)
12-03 21:34:38.240+0900 D/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 21:34:38.240+0900 E/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 21:34:38.240+0900 E/RESOURCED( 2896): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.841
12-03 21:34:38.240+0900 I/ESD     ( 2959): esd_main.c: __esd_app_dead_handler(1771) > pid: 12558
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_launch.c: __e17_status_handler(2891) > pid(2908) status(3)
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
12-03 21:34:38.240+0900 W/AUL_AMD ( 2802): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
12-03 21:34:38.240+0900 W/AUL_AMD ( 2802): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(456) > pid(2908) status(3)
12-03 21:34:38.240+0900 D/AUL_AMD ( 2802): amd_status.c: _status_update_app_info_list(468) > pid(2908) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
12-03 21:34:38.240+0900 D/AUL     ( 2802): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
12-03 21:34:38.240+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2908, appid: org.tizen.homescreen, status: fg
12-03 21:34:38.240+0900 D/RESOURCED( 2896): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 12558
12-03 21:34:38.240+0900 D/RESOURCED( 2896): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 0
12-03 21:34:38.240+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2908
12-03 21:34:38.240+0900 D/RESOURCED( 2896): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2908, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
12-03 21:34:38.240+0900 D/RESOURCED( 2896): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2908, appname = org.tizen.homescreen
12-03 21:34:38.240+0900 D/RESOURCED( 2896): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2908
12-03 21:34:38.270+0900 E/E17     ( 2803): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
12-03 21:34:38.270+0900 W/CRASH_MANAGER(12659): worker.c: worker_job(1204) > 1112558646472148076847
