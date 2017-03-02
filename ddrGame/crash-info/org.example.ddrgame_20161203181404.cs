S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: ddrgame
PID: 17076
Date: 2016-12-03 18:14:04+0900
Executable File Path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbf843140, esi = 0x00000003
ebp = 0xbf842f58, esp = 0xbf842d68
eax = 0xbf842e0c, ebx = 0xb3801140
ecx = 0xbf842e0c, edx = 0x00000003
eip = 0xb6d21df9

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         7 KB
Cached:     159680 KB
VmPeak:      80028 KB
VmSize:      80028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15852 KB
VmRSS:       15852 KB
VmData:      19976 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33448 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17076 TID = 17076
17076 17103 17107 

Maps Information
b2cc1000 b2ccb000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cd1000 b2cdd000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cde000 b2cff000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d04000 b2d05000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d06000 b2d0b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d0c000 b2d0d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d0e000 b2d10000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d11000 b2d13000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d14000 b2d20000 r-xp /usr/lib/libdrm.so.2.4.0
b2d21000 b2d2b000 r-xp /usr/lib/libtbm.so.1.0.0
b2d2c000 b2d41000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d42000 b2d54000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3556000 b355f000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3560000 b3569000 r-xp /usr/lib/libefl-extension.so.0.1.0
b356a000 b357c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3583000 b3584000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3585000 b3586000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3587000 b358a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b358b000 b358e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3696000 b369c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b369d000 b37e1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f1000 b37f4000 r-xp /usr/lib/libdri2.so.0.0.0
b37f5000 b37f6000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37f7000 b37fd000 r-xp /usr/lib/libcapi-system-sensor.so.0.2.0
b37fe000 b3801000 r-xp /opt/usr/apps/org.example.ddrgame/bin/ddrgame
b3803000 b383c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b423f000 b424a000 r-xp /lib/libnss_files-2.20-2014.11.so
b424c000 b4257000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4259000 b4270000 r-xp /lib/libnsl-2.20-2014.11.so
b4274000 b427c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b427e000 b42a2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42a3000 b42a4000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42a5000 b42a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42a9000 b42b0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b1000 b42bb000 r-xp /usr/lib/libsensord-share.so
b42bc000 b42d8000 r-xp /usr/lib/libsensor.so.1.2.0
b42da000 b42e3000 r-xp /usr/lib/libappcore-common.so.1.1
b42e6000 b42e8000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42fd000 b42ff000 r-xp /usr/lib/libXau.so.6.0.0
b4300000 b4322000 r-xp /usr/lib/libxcb.so.1.1.0
b4324000 b432d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4356000 b4358000 r-xp /usr/lib/libiri.so
b4359000 b437f000 r-xp /lib/libexpat.so.1.5.2
b4381000 b43ec000 r-xp /usr/lib/libssl.so.1.0.0
b43f2000 b43fe000 r-xp /usr/lib/libethumb.so.1.13.0
b43ff000 b4403000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4404000 b4655000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd0000 b5be0000 r-xp /usr/lib/libXi.so.6.1.0
b5be1000 b5be3000 r-xp /usr/lib/libXgesture.so.7.0.0
b5be4000 b5bea000 r-xp /usr/lib/libXtst.so.6.1.0
b5beb000 b5bf5000 r-xp /usr/lib/libXrender.so.1.3.0
b5bf6000 b5bff000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c01000 b5c03000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c04000 b5c09000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c0a000 b5c1c000 r-xp /usr/lib/libXext.so.6.4.0
b5c1d000 b5c1f000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c20000 b5c22000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c24000 b5d66000 r-xp /usr/lib/libX11.so.6.3.0
b5d6a000 b5d74000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d75000 b5d8b000 r-xp /usr/lib/libudev.so.1.6.0
b5d8e000 b5d92000 r-xp /lib/libattr.so.1.1.0
b5d93000 b5dc2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dc4000 b5dca000 r-xp /usr/lib/libffi.so.6.0.2
b5dcb000 b5dee000 r-xp /lib/libz.so.1.2.8
b5def000 b5df2000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5df3000 b5f4f000 r-xp /usr/lib/libxml2.so.2.9.2
b5f55000 b603c000 r-xp /usr/lib/libstdc++.so.6.0.20
b6049000 b604c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b604d000 b606f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6070000 b6084000 r-xp /lib/libresolv-2.20-2014.11.so
b6088000 b60ac000 r-xp /usr/lib/liblzma.so.5.0.3
b60ad000 b60af000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b1000 b60bb000 r-xp /usr/lib/libembryo.so.1.13.0
b60bc000 b60e5000 r-xp /usr/lib/libpng12.so.0.50.0
b60e6000 b612f000 r-xp /usr/lib/libjpeg.so.8.0.2
b6140000 b6147000 r-xp /lib/librt-2.20-2014.11.so
b6149000 b6168000 r-xp /usr/lib/libector.so.1.13.0
b616b000 b6198000 r-xp /usr/lib/liblua-5.1.so
b6199000 b6229000 r-xp /usr/lib/libfreetype.so.6.11.3
b622d000 b626b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b626c000 b6282000 r-xp /usr/lib/libfribidi.so.0.3.1
b6283000 b62dc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62df000 b632a000 r-xp /lib/libm-2.20-2014.11.so
b632c000 b633e000 r-xp /usr/lib/libeio.so.1.13.0
b633f000 b6342000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6343000 b6349000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b634a000 b636d000 r-xp /usr/lib/libefreet.so.1.13.0
b6370000 b639b000 r-xp /usr/lib/libeldbus.so.1.13.0
b639c000 b63d0000 r-xp /usr/lib/libecore_con.so.1.13.0
b63d2000 b63db000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63dc000 b63e5000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63e6000 b63f9000 r-xp /usr/lib/libeo.so.1.13.0
b63fb000 b640e000 r-xp /usr/lib/libecore_input.so.1.13.0
b640f000 b6416000 r-xp /usr/lib/libecore_file.so.1.13.0
b6417000 b643a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b643b000 b6467000 r-xp /usr/lib/libeet.so.1.13.0
b6470000 b64db000 r-xp /usr/lib/libeina.so.1.13.0
b64de000 b64f5000 r-xp /usr/lib/libefl.so.1.13.0
b64f7000 b665e000 r-xp /usr/lib/libicuuc.so.51.1
b666c000 b6878000 r-xp /usr/lib/libicui18n.so.51.1
b6880000 b68cf000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d1000 b68eb000 r-xp /lib/libgcc_s-4.9.so.1
b68ed000 b68f1000 r-xp /lib/libcap.so.2.21
b68f2000 b6938000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6939000 b6940000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6942000 b6994000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6996000 b6b21000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b26000 b6bf4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bf7000 b6bfb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bfc000 b6c0b000 r-xp /usr/lib/libvconf.so.0.2.45
b6c0c000 b6c0f000 r-xp /usr/lib/libvasum.so.0.3.1
b6c10000 b6c13000 r-xp /usr/lib/libttrace.so.1.1
b6c15000 b6c19000 r-xp /usr/lib/libiniparser.so.0
b6c1a000 b6c4a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c4b000 b6c54000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c55000 b6c7a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c7b000 b6c8b000 r-xp /usr/lib/libunwind.so.8.0.1
b6c95000 b6e43000 r-xp /lib/libc-2.20-2014.11.so
b6e4b000 b6f8e000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f90000 b6fe8000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fe9000 b701d000 r-xp /usr/lib/libsystemd.so.0.4.0
b7020000 b70f4000 r-xp /usr/lib/libedje.so.1.13.0
b70f7000 b7123000 r-xp /usr/lib/libecore.so.1.13.0
b7134000 b735a000 r-xp /usr/lib/libevas.so.1.13.0
b7382000 b739a000 r-xp /lib/libpthread-2.20-2014.11.so
b739e000 b7718000 r-xp /usr/lib/libelementary.so.1.13.0
b7738000 b773c000 r-xp /usr/lib/libsmack.so.1.0.0
b773d000 b7746000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7747000 b774a000 r-xp /usr/lib/libdlog.so.0.0.0
b774b000 b7750000 r-xp /usr/lib/libbundle.so.0.1.22
b7751000 b7754000 r-xp /lib/libdl-2.20-2014.11.so
b7756000 b777b000 r-xp /usr/lib/libaul.so.0.1.0
b777e000 b7780000 r-xp /usr/lib/libappsvc.so.0.1.0
b7781000 b7786000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7787000 b778e000 r-xp /usr/lib/libappcore-efl.so.1.1
b7790000 b7795000 r-xp /usr/lib/libsys-assert.so
b7798000 b7799000 r-xp [vdso]
b7799000 b77bb000 r-xp /lib/ld-2.20-2014.11.so
b77bd000 b77c5000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17076)
Call Stack Count: 8
 0: (0xb6d21df9) [/lib/libc.so.6] + 0x8cdf9
 1: app_create + 0x2c (0xb37ff64c) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x164c
 2: (0xb778361b) [/usr/lib/libcapi-appfw-application.so.0] + 0x261b
 3: appcore_efl_main + 0x327 (0xb778ac27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb7783c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
 5: main + 0x29e (0xb37ff5be) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x15be
 6: stageInit + 0x48 (0xb77bf148) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0xb77bf148
 7: __libc_start_main + 0xde (0xb6cace4e) [/lib/libc.so.6] + 0x17e4e
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
03 18:13:59.331+0900 D/cluster-view( 2917): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
12-03 18:13:59.331+0900 D/cluster-view( 2917): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[60010]
12-03 18:13:59.331+0900 D/cluster-view( 2917): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[60010]
12-03 18:14:00.151+0900 D/PROCESSMGR( 2844): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1600002
12-03 18:14:00.331+0900 D/cluster-home( 2917): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
12-03 18:14:00.331+0900 D/WIDGET_VIEWER( 2917): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.tizen.calendar.widget] visibility is changed 0x[2]
12-03 18:14:00.341+0900 D/DATA_PROVIDER_MASTER( 2961): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
12-03 18:14:00.341+0900 I/CAPI_WIDGET_APPLICATION( 3058): widget_app.c: __provider_pause_cb(294) > widget obj was paused
12-03 18:14:00.341+0900 I/CAPI_WIDGET_APPLICATION( 3058): widget_app.c: __check_status_for_cgroup(142) > enter background group
12-03 18:14:00.341+0900 W/AUL     ( 3058): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3058, appid: org.tizen.calendar.widget, status: bg
12-03 18:14:00.341+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3058, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
12-03 18:14:00.341+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3058
12-03 18:14:00.341+0900 D/RESOURCED( 2897): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3058, appname = org.tizen.calendar.widget
12-03 18:14:00.341+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3058
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 6:14 4 h"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 6:14"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 6&#x2236;14"
12-03 18:14:00.861+0900 D/INDICATOR( 2899): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146516123 Time: <font_size=33>6&#x2236;14</font_size> <font_size=32>PM</font_size></font>
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
12-03 18:14:01.301+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[91.00][357.00] to[91.00][357.00]!
12-03 18:14:01.301+0900 D/cluster-view( 2917): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
12-03 18:14:01.301+0900 D/cluster-home( 2917): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
12-03 18:14:01.301+0900 D/cluster-home( 2917): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
12-03 18:14:01.301+0900 D/AUL     ( 2917): service.c: __set_bundle(186) > __set_bundle
12-03 18:14:01.301+0900 D/AUL     ( 2917): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
12-03 18:14:01.301+0900 D/AUL     ( 2917): service.c: __set_bundle(186) > __set_bundle
12-03 18:14:01.301+0900 D/AUL     ( 2917): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.ddrgame - no result
12-03 18:14:01.301+0900 D/AUL     ( 2917): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.ddrgame
12-03 18:14:01.301+0900 D/AUL     ( 2917): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 18:14:01.301+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
12-03 18:14:01.301+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2233) > caller pid : 2917
12-03 18:14:01.301+0900 D/PROCESSMGR( 2844): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_key.c: _key_grab(243) > _key_grab, win : a00002
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2448) > back key grab
12-03 18:14:01.301+0900 W/AUL_AMD ( 2790): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 18:14:01.301+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 18:14:01.301+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
12-03 18:14:01.301+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2648) > process_pool: false
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 18:14:01.301+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 18:14:01.301+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 18:14:01.301+0900 D/AUL     ( 2790): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 18:14:01.301+0900 W/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 18:14:01.301+0900 D/AUL     ( 2959): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17030, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:01.301+0900 W/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 18:14:01.301+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 18:14:01.301+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 18:14:01.301+0900 D/AUL     (17030): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17054) is sent.
12-03 18:14:01.301+0900 D/AUL     (17030): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17054, signo: 10
12-03 18:14:01.311+0900 D/AUL     (17030): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmRkcmdhbWUA##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NTY0NDEvMzE0MjE5AA==##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTE3AA==##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 14
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 18:14:01.311+0900 D/AUL_PAD (17030): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 18:14:01.311+0900 I/CAPI_APPFW_APPLICATION(17030): app_main.c: ui_app_main(788) > app_efl_main
12-03 18:14:01.311+0900 D/LAUNCH  (17030): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 18:14:01.311+0900 D/APP_CORE(17030): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:14:01.311+0900 D/APP_CORE(17030): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 18:14:01.311+0900 D/APP_CORE(17030): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:14:01.311+0900 D/APP_CORE(17030): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:14:01.311+0900 D/AUL     (17030): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:14:01.311+0900 D/APP_CORE(17030): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4253520
12-03 18:14:01.311+0900 D/LAUNCH  (17030): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 18:14:01.311+0900 I/CAPI_APPFW_APPLICATION(17030): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.361+0900 E/EFL     (17030): eo<17030> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:01.381+0900 W/CRASH_MANAGER(16760): worker.c: worker_job(1204) > 11170306464721480756441
12-03 18:14:01.401+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 17030
12-03 18:14:01.401+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 17030
12-03 18:14:01.401+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
12-03 18:14:01.401+0900 W/AUL     ( 2790): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 17030, appid: org.example.ddrgame
12-03 18:14:01.401+0900 D/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 18:14:01.401+0900 E/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 18:14:01.401+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2700) > add app group info
12-03 18:14:01.401+0900 E/AUL     ( 2790): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
12-03 18:14:01.401+0900 D/AUL_AMD ( 2790): amd_status.c: _status_add_app_info_list(427) > pid(17030) appid(org.example.ddrgame) pkgid(org.example.ddrgame) comp(uiapp)
12-03 18:14:01.401+0900 D/AUL     ( 2917): launch.c: app_request_to_launchpad(425) > launch request result : 17030
12-03 18:14:01.401+0900 E/cluster-home( 2917): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.ddrgame]
12-03 18:14:01.401+0900 D/test-log( 2917): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
12-03 18:14:01.401+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.ddrgame, 17030
12-03 18:14:01.401+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.ddrgame with pkgname
12-03 18:14:01.401+0900 E/RESOURCED( 2897): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.ddrgame
12-03 18:14:01.401+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(888) > available memory = 301
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:14:02.171+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:14:02.171+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.171+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:14:02.171+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:14:02.171+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:14:02.171+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.171+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.181+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:14:02.181+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:14:02.181+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:14:02.181+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:14:02.181+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:14:02.181+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.181+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.191+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:14:02.191+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:14:02.191+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:14:02.191+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:14:02.191+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:14:02.321+0900 D/LAUNCH  (17073): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
12-03 18:14:02.321+0900 D/PKGMGR_INFO(17073): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.321+0900 D/PKGMGR_INFO(17073): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
12-03 18:14:02.321+0900 D/AUL     (17073): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 17073 is org.tizen.crash-popup
12-03 18:14:02.381+0900 D/APP_CORE(17073): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:14:02.381+0900 D/APP_CORE(17073): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
12-03 18:14:02.381+0900 D/APP_CORE(17073): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:14:02.401+0900 D/APP_CORE(17073): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:14:02.401+0900 D/AUL     (17073): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:14:02.401+0900 D/APP_CORE(17073): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb77a2520
12-03 18:14:02.401+0900 D/LAUNCH  (17073): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
12-03 18:14:02.401+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
12-03 18:14:02.401+0900 D/AUL_PAD (17076): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
12-03 18:14:02.411+0900 D/AUL_AMD ( 2790): amd_launch.c: __grab_timeout_handler(1445) > pid(17030) ecore_x_pointer_ungrab
12-03 18:14:02.411+0900 D/AUL_AMD ( 2790): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
12-03 18:14:02.411+0900 D/AUL_AMD ( 2790): amd_launch.c: __grab_timeout_handler(1449) > back key ungrab
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_launch_signal(131) > send launch signal done
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:14:02.411+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:14:02.411+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 17030 pgid = 17030
12-03 18:14:02.411+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(142) > dead_pid(17030)
12-03 18:14:02.411+0900 D/APP_CORE(17073): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:14:02.431+0900 D/LAUNCH  (17073): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
12-03 18:14:02.431+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_dead_signal(90) > send dead signal done
12-03 18:14:02.431+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
12-03 18:14:02.431+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
12-03 18:14:02.431+0900 E/AUL_PAD ( 2959): launchpad.c: main(688) > error reading sigchld info
12-03 18:14:02.431+0900 I/ESD     ( 2958): esd_main.c: __esd_app_dead_handler(1771) > pid: 17030
12-03 18:14:02.431+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 17030 is termianted
12-03 18:14:02.431+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
12-03 18:14:02.431+0900 W/AUL_AMD ( 2790): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 17030
12-03 18:14:02.431+0900 W/AUL_AMD ( 2790): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 17030
12-03 18:14:02.431+0900 D/AUL_AMD ( 2790): amd_key.c: _unregister_key_event(179) > ===key stack===
12-03 18:14:02.431+0900 E/AUL_AMD ( 2790): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
12-03 18:14:02.431+0900 D/AUL_AMD ( 2790): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.ddrgame)
12-03 18:14:02.431+0900 D/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 18:14:02.431+0900 E/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 18:14:02.441+0900 E/RESOURCED( 2897): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1089
12-03 18:14:02.441+0900 D/APP_CORE(17073): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
12-03 18:14:02.451+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 17030
12-03 18:14:02.451+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 0
12-03 18:14:02.711+0900 E/RESOURCED( 2897): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
12-03 18:14:02.911+0900 D/AUL_AMD ( 2790): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.ddrgame /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:02.911+0900 D/RUA     ( 2790): rua.c: rua_add_history(179) > rua_add_history start
12-03 18:14:02.911+0900 D/RUA     ( 2790): rua.c: rua_add_history(247) > rua_add_history ok
12-03 18:14:03.451+0900 D/AUL_PAD (17076): launchpad_loader.c: main(588) > sleeping 1 sec...
12-03 18:14:03.451+0900 D/AUL_PAD (17076): preload.h: __preload_init(52) > max_cmdline_size = 1053
12-03 18:14:03.451+0900 D/AUL_PAD (17076): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b89e7760
12-03 18:14:03.451+0900 D/AUL_PAD (17076): preload.h: __preload_init(69) > get pre-initialization function
12-03 18:14:03.451+0900 D/AUL_PAD (17076): preload.h: __preload_init(73) > get shutdown function
12-03 18:14:03.451+0900 D/AUL_PAD (17076): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b89e7a40
12-03 18:14:03.461+0900 D/AUL_PAD (17076): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b89e9640
12-03 18:14:03.461+0900 D/AUL_PAD (17076): preload.h: __preload_init(69) > get pre-initialization function
12-03 18:14:03.461+0900 D/AUL_PAD (17076): preload.h: __preload_init(73) > get shutdown function
12-03 18:14:03.461+0900 D/AUL_PAD (17076): preexec.h: __preexec_init(76) > preexec start
12-03 18:14:03.461+0900 D/AUL_PAD (17076): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
12-03 18:14:03.461+0900 D/AUL     (17076): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
12-03 18:14:03.461+0900 D/AUL     (17076): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
12-03 18:14:03.461+0900 D/AUL     (17076): process_pool.c: __connect_to_launchpad(132) > send(17076) : 4
12-03 18:14:03.461+0900 D/AUL     (17076): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
12-03 18:14:03.461+0900 D/AUL_PAD ( 2959): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 17076
12-03 18:14:03.551+0900 D/AUL_PAD (17076): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
12-03 18:14:03.561+0900 D/AUL_PAD (17076): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
12-03 18:14:03.561+0900 D/AUL_PAD (17076): launchpad_loader.c: main(693) > [candidate] ecore handler add
12-03 18:14:03.561+0900 D/AUL_PAD (17076): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
12-03 18:14:04.611+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
12-03 18:14:04.611+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
12-03 18:14:04.641+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
12-03 18:14:04.641+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
12-03 18:14:04.641+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
12-03 18:14:04.641+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
12-03 18:14:04.641+0900 D/test-log( 2917): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[121.00][381.00] to[121.00][381.00]!
12-03 18:14:04.641+0900 D/cluster-view( 2917): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
12-03 18:14:04.641+0900 D/cluster-home( 2917): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
12-03 18:14:04.641+0900 D/cluster-home( 2917): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
12-03 18:14:04.641+0900 D/AUL     ( 2917): service.c: __set_bundle(186) > __set_bundle
12-03 18:14:04.641+0900 D/AUL     ( 2917): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
12-03 18:14:04.641+0900 D/AUL     ( 2917): service.c: __set_bundle(186) > __set_bundle
12-03 18:14:04.641+0900 D/AUL     ( 2917): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.ddrgame - no result
12-03 18:14:04.641+0900 D/AUL     ( 2917): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.ddrgame
12-03 18:14:04.641+0900 D/AUL     ( 2917): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
12-03 18:14:04.641+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 18:14:04.651+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 18:14:04.651+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
12-03 18:14:04.651+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2233) > caller pid : 2917
12-03 18:14:04.651+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
12-03 18:14:04.651+0900 D/AUL_AMD ( 2790): amd_key.c: _key_grab(243) > _key_grab, win : a00002
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2448) > back key grab
12-03 18:14:04.661+0900 W/AUL_AMD ( 2790): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 18:14:04.661+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 18:14:04.661+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 18:14:04.661+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2648) > process_pool: false
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 18:14:04.661+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 18:14:04.661+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 18:14:04.661+0900 D/AUL     ( 2790): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 18:14:04.661+0900 W/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 18:14:04.661+0900 D/AUL     ( 2959): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17076, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:04.661+0900 W/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 18:14:04.661+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 18:14:04.661+0900 D/AUL     (17076): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17103) is sent.
12-03 18:14:04.661+0900 D/AUL     (17076): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17103, signo: 10
12-03 18:14:04.661+0900 D/AUL     (17076): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmRkcmdhbWUA##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NTY0NDQvNjU5NjQyAA==##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTE3AA==##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 14
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 18:14:04.661+0900 D/AUL_PAD (17076): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 18:14:04.671+0900 I/CAPI_APPFW_APPLICATION(17076): app_main.c: ui_app_main(788) > app_efl_main
12-03 18:14:04.671+0900 D/LAUNCH  (17076): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 18:14:04.671+0900 D/APP_CORE(17076): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:14:04.671+0900 D/APP_CORE(17076): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 18:14:04.671+0900 D/APP_CORE(17076): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:14:04.671+0900 D/APP_CORE(17076): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:14:04.671+0900 D/AUL     (17076): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:14:04.671+0900 D/APP_CORE(17076): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e3520
12-03 18:14:04.671+0900 D/LAUNCH  (17076): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 18:14:04.671+0900 I/CAPI_APPFW_APPLICATION(17076): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 18:14:04.681+0900 D/PROCESSMGR( 2844): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
12-03 18:14:04.711+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.711+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.711+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.711+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.731+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.731+0900 E/EFL     (17076): eo<17076> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:14:04.741+0900 W/CRASH_MANAGER(16760): worker.c: worker_job(1204) > 1117076646472148075644
