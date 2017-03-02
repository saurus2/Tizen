S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: ddrgame
PID: 16775
Date: 2016-12-03 18:13:42+0900
Executable File Path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfc0cef0, esi = 0x00000001
ebp = 0xbfc0cd08, esp = 0xbfc0cb18
eax = 0xbfc0cbbc, ebx = 0xb383d140
ecx = 0xbfc0cbbc, edx = 0x00000001
eip = 0xb6d5ddf9

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         7 KB
Cached:     159412 KB
VmPeak:      80028 KB
VmSize:      80028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15856 KB
VmRSS:       15856 KB
VmData:      19976 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33448 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 16775 TID = 16775
16775 16802 16891 

Maps Information
b2cfd000 b2d07000 r-xp /usr/lib/libfeedback.so.0.1.4
b2d0d000 b2d19000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2d1a000 b2d3b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d40000 b2d41000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d42000 b2d47000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d48000 b2d49000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d4a000 b2d4c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d4d000 b2d4f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d50000 b2d5c000 r-xp /usr/lib/libdrm.so.2.4.0
b2d5d000 b2d67000 r-xp /usr/lib/libtbm.so.1.0.0
b2d68000 b2d7d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d7e000 b2d90000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3592000 b359b000 r-xp /usr/lib/libeventsystem.so.0.0.1
b359c000 b35a5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b35a6000 b35b8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b35bf000 b35c0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35c1000 b35c2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35c3000 b35c6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c7000 b35ca000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36d2000 b36d8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d9000 b381d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b382d000 b3830000 r-xp /usr/lib/libdri2.so.0.0.0
b3831000 b3832000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3833000 b3839000 r-xp /usr/lib/libcapi-system-sensor.so.0.2.0
b383a000 b383d000 r-xp /opt/usr/apps/org.example.ddrgame/bin/ddrgame
b383f000 b3878000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b427b000 b4286000 r-xp /lib/libnss_files-2.20-2014.11.so
b4288000 b4293000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4295000 b42ac000 r-xp /lib/libnsl-2.20-2014.11.so
b42b0000 b42b8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42ba000 b42de000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42df000 b42e0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42e1000 b42e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e5000 b42ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ed000 b42f7000 r-xp /usr/lib/libsensord-share.so
b42f8000 b4314000 r-xp /usr/lib/libsensor.so.1.2.0
b4316000 b431f000 r-xp /usr/lib/libappcore-common.so.1.1
b4322000 b4324000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4339000 b433b000 r-xp /usr/lib/libXau.so.6.0.0
b433c000 b435e000 r-xp /usr/lib/libxcb.so.1.1.0
b4360000 b4369000 r-xp /lib/libcrypt-2.20-2014.11.so
b4392000 b4394000 r-xp /usr/lib/libiri.so
b4395000 b43bb000 r-xp /lib/libexpat.so.1.5.2
b43bd000 b4428000 r-xp /usr/lib/libssl.so.1.0.0
b442e000 b443a000 r-xp /usr/lib/libethumb.so.1.13.0
b443b000 b443f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4440000 b4691000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c0c000 b5c1c000 r-xp /usr/lib/libXi.so.6.1.0
b5c1d000 b5c1f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c20000 b5c26000 r-xp /usr/lib/libXtst.so.6.1.0
b5c27000 b5c31000 r-xp /usr/lib/libXrender.so.1.3.0
b5c32000 b5c3b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3d000 b5c3f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c40000 b5c45000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c46000 b5c58000 r-xp /usr/lib/libXext.so.6.4.0
b5c59000 b5c5b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c5c000 b5c5e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c60000 b5da2000 r-xp /usr/lib/libX11.so.6.3.0
b5da6000 b5db0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5db1000 b5dc7000 r-xp /usr/lib/libudev.so.1.6.0
b5dca000 b5dce000 r-xp /lib/libattr.so.1.1.0
b5dcf000 b5dfe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5e00000 b5e06000 r-xp /usr/lib/libffi.so.6.0.2
b5e07000 b5e2a000 r-xp /lib/libz.so.1.2.8
b5e2b000 b5e2e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2f000 b5f8b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f91000 b6078000 r-xp /usr/lib/libstdc++.so.6.0.20
b6085000 b6088000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6089000 b60ab000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60ac000 b60c0000 r-xp /lib/libresolv-2.20-2014.11.so
b60c4000 b60e8000 r-xp /usr/lib/liblzma.so.5.0.3
b60e9000 b60eb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ed000 b60f7000 r-xp /usr/lib/libembryo.so.1.13.0
b60f8000 b6121000 r-xp /usr/lib/libpng12.so.0.50.0
b6122000 b616b000 r-xp /usr/lib/libjpeg.so.8.0.2
b617c000 b6183000 r-xp /lib/librt-2.20-2014.11.so
b6185000 b61a4000 r-xp /usr/lib/libector.so.1.13.0
b61a7000 b61d4000 r-xp /usr/lib/liblua-5.1.so
b61d5000 b6265000 r-xp /usr/lib/libfreetype.so.6.11.3
b6269000 b62a7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a8000 b62be000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bf000 b6318000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b631b000 b6366000 r-xp /lib/libm-2.20-2014.11.so
b6368000 b637a000 r-xp /usr/lib/libeio.so.1.13.0
b637b000 b637e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637f000 b6385000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6386000 b63a9000 r-xp /usr/lib/libefreet.so.1.13.0
b63ac000 b63d7000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d8000 b640c000 r-xp /usr/lib/libecore_con.so.1.13.0
b640e000 b6417000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6418000 b6421000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6422000 b6435000 r-xp /usr/lib/libeo.so.1.13.0
b6437000 b644a000 r-xp /usr/lib/libecore_input.so.1.13.0
b644b000 b6452000 r-xp /usr/lib/libecore_file.so.1.13.0
b6453000 b6476000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6477000 b64a3000 r-xp /usr/lib/libeet.so.1.13.0
b64ac000 b6517000 r-xp /usr/lib/libeina.so.1.13.0
b651a000 b6531000 r-xp /usr/lib/libefl.so.1.13.0
b6533000 b669a000 r-xp /usr/lib/libicuuc.so.51.1
b66a8000 b68b4000 r-xp /usr/lib/libicui18n.so.51.1
b68bc000 b690b000 r-xp /usr/lib/libecore_x.so.1.13.0
b690d000 b6927000 r-xp /lib/libgcc_s-4.9.so.1
b6929000 b692d000 r-xp /lib/libcap.so.2.21
b692e000 b6974000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6975000 b697c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697e000 b69d0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69d2000 b6b5d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b62000 b6c30000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c33000 b6c37000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c38000 b6c47000 r-xp /usr/lib/libvconf.so.0.2.45
b6c48000 b6c4b000 r-xp /usr/lib/libvasum.so.0.3.1
b6c4c000 b6c4f000 r-xp /usr/lib/libttrace.so.1.1
b6c51000 b6c55000 r-xp /usr/lib/libiniparser.so.0
b6c56000 b6c86000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c87000 b6c90000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c91000 b6cb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb7000 b6cc7000 r-xp /usr/lib/libunwind.so.8.0.1
b6cd1000 b6e7f000 r-xp /lib/libc-2.20-2014.11.so
b6e87000 b6fca000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fcc000 b7024000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7025000 b7059000 r-xp /usr/lib/libsystemd.so.0.4.0
b705c000 b7130000 r-xp /usr/lib/libedje.so.1.13.0
b7133000 b715f000 r-xp /usr/lib/libecore.so.1.13.0
b7170000 b7396000 r-xp /usr/lib/libevas.so.1.13.0
b73be000 b73d6000 r-xp /lib/libpthread-2.20-2014.11.so
b73da000 b7754000 r-xp /usr/lib/libelementary.so.1.13.0
b7774000 b7778000 r-xp /usr/lib/libsmack.so.1.0.0
b7779000 b7782000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7783000 b7786000 r-xp /usr/lib/libdlog.so.0.0.0
b7787000 b778c000 r-xp /usr/lib/libbundle.so.0.1.22
b778d000 b7790000 r-xp /lib/libdl-2.20-2014.11.so
b7792000 b77b7000 r-xp /usr/lib/libaul.so.0.1.0
b77ba000 b77bc000 r-xp /usr/lib/libappsvc.so.0.1.0
b77bd000 b77c2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c3000 b77ca000 r-xp /usr/lib/libappcore-efl.so.1.1
b77cc000 b77d1000 r-xp /usr/lib/libsys-assert.so
b77d4000 b77d5000 r-xp [vdso]
b77d5000 b77f7000 r-xp /lib/ld-2.20-2014.11.so
b77f9000 b7801000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:16775)
Call Stack Count: 8
 0: (0xb6d5ddf9) [/lib/libc.so.6] + 0x8cdf9
 1: app_create + 0x2c (0xb383b64c) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x164c
 2: (0xb77bf61b) [/usr/lib/libcapi-appfw-application.so.0] + 0x261b
 3: appcore_efl_main + 0x327 (0xb77c6c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb77bfc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
 5: main + 0x29e (0xb383b5be) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x15be
 6: stageInit + 0x48 (0xb77fb148) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0xb77fb148
 7: __libc_start_main + 0xde (0xb6ce8e4e) [/lib/libc.so.6] + 0x17e4e
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
] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 18:13:33.612+0900 I/AUL     ( 2790): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
12-03 18:13:33.612+0900 D/AUL     ( 2790): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 16753, pid = 16755
12-03 18:13:33.622+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:13:33.622+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:13:33.622+0900 I/AUL     ( 2790): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
12-03 18:13:33.622+0900 E/AUL_AMD ( 2790): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
12-03 18:13:33.622+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2233) > caller pid : 16755
12-03 18:13:33.622+0900 E/AUL_AMD ( 2790): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
12-03 18:13:33.622+0900 W/AUL_AMD ( 2790): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 18:13:33.622+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2648) > process_pool: false
12-03 18:13:33.622+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 18:13:33.622+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 18:13:33.622+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 18:13:33.622+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 18:13:33.622+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 18:13:33.622+0900 D/AUL     ( 2790): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 18:13:33.622+0900 W/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 18:13:33.622+0900 D/AUL     ( 2959): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 16574, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:33.622+0900 W/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 18:13:33.622+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 18:13:33.622+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 18:13:33.622+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 18:13:33.622+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 18:13:33.622+0900 D/AUL     (16574): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (16575) is sent.
12-03 18:13:33.622+0900 D/AUL     (16574): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 16575, signo: 10
12-03 18:13:33.622+0900 D/AUL     (16574): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NTY0MTMvNjI2MTA2AA==##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNjc1NQA=##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 8
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 18:13:33.622+0900 D/AUL_PAD (16574): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 18:13:33.632+0900 I/CAPI_APPFW_APPLICATION(16574): app_main.c: ui_app_main(788) > app_efl_main
12-03 18:13:33.632+0900 D/LAUNCH  (16574): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 18:13:33.632+0900 D/APP_CORE(16574): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:13:33.632+0900 D/APP_CORE(16574): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 18:13:33.632+0900 D/APP_CORE(16574): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:13:33.642+0900 D/APP_CORE(16574): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:13:33.642+0900 D/AUL     (16574): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:13:33.642+0900 D/APP_CORE(16574): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4316520
12-03 18:13:33.642+0900 D/LAUNCH  (16574): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 18:13:33.642+0900 I/CAPI_APPFW_APPLICATION(16574): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.692+0900 E/EFL     (16574): eo<16574> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:33.732+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 16574
12-03 18:13:33.732+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 16574
12-03 18:13:33.732+0900 E/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
12-03 18:13:33.732+0900 W/AUL     ( 2790): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 16574, appid: org.example.ddrgame
12-03 18:13:33.732+0900 D/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 18:13:33.732+0900 E/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 18:13:33.732+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2700) > add app group info
12-03 18:13:33.732+0900 E/AUL     ( 2790): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
12-03 18:13:33.732+0900 D/AUL_AMD ( 2790): amd_status.c: _status_add_app_info_list(427) > pid(16574) appid(org.example.ddrgame) pkgid(org.example.ddrgame) comp(uiapp)
12-03 18:13:33.732+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.ddrgame, 16574
12-03 18:13:33.732+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.ddrgame with pkgname
12-03 18:13:33.732+0900 E/RESOURCED( 2897): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.ddrgame
12-03 18:13:33.732+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(888) > available memory = 301
12-03 18:13:33.762+0900 W/CRASH_MANAGER(16760): worker.c: worker_job(1204) > 11165746464721480756413
12-03 18:13:34.512+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:13:34.512+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:13:34.512+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:13:34.512+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:13:34.512+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:13:34.512+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.512+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:13:34.522+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:13:34.522+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.522+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:13:34.522+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:13:34.522+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.522+0900 D/PKGMGR_INFO(16760): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ddrgame/bin/ddrgame' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
12-03 18:13:34.522+0900 E/VCONF   (16760): vconf.c: vconf_get_str(2891) > vconf_get_str(16760) : db/menu_widget/language error
12-03 18:13:34.522+0900 E/PKGMGR_INFO(16760): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
12-03 18:13:34.662+0900 D/LAUNCH  (16772): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
12-03 18:13:34.662+0900 D/PKGMGR_INFO(16772): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.662+0900 D/PKGMGR_INFO(16772): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
12-03 18:13:34.662+0900 D/AUL     (16772): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 16772 is org.tizen.crash-popup
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
12-03 18:13:34.732+0900 D/AUL_PAD (16775): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
12-03 18:13:34.732+0900 D/AUL_AMD ( 2790): amd_launch.c: __grab_timeout_handler(1445) > pid(16574) ecore_x_pointer_ungrab
12-03 18:13:34.732+0900 D/AUL_AMD ( 2790): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
12-03 18:13:34.732+0900 W/AUL_AMD ( 2790): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
12-03 18:13:34.732+0900 W/AUL_AMD ( 2790): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
12-03 18:13:34.732+0900 D/APP_CORE(16772): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:13:34.732+0900 D/APP_CORE(16772): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
12-03 18:13:34.732+0900 D/APP_CORE(16772): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_launch_signal(131) > send launch signal done
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:13:34.732+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:13:34.732+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 16574 pgid = 16574
12-03 18:13:34.732+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(142) > dead_pid(16574)
12-03 18:13:34.752+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_dead_signal(90) > send dead signal done
12-03 18:13:34.752+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
12-03 18:13:34.752+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
12-03 18:13:34.752+0900 E/AUL_PAD ( 2959): launchpad.c: main(688) > error reading sigchld info
12-03 18:13:34.752+0900 D/APP_CORE(16772): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:13:34.752+0900 D/APP_CORE(16772): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7743520
12-03 18:13:34.752+0900 D/LAUNCH  (16772): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
12-03 18:13:34.762+0900 I/ESD     ( 2958): esd_main.c: __esd_app_dead_handler(1771) > pid: 16574
12-03 18:13:34.762+0900 W/AUL_AMD ( 2790): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 16574
12-03 18:13:34.762+0900 W/AUL_AMD ( 2790): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 16574
12-03 18:13:34.762+0900 D/AUL_AMD ( 2790): amd_key.c: _unregister_key_event(179) > ===key stack===
12-03 18:13:34.762+0900 E/AUL_AMD ( 2790): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
12-03 18:13:34.762+0900 D/AUL_AMD ( 2790): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.ddrgame)
12-03 18:13:34.762+0900 D/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 18:13:34.762+0900 E/AUL     ( 2790): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 18:13:34.762+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 16574 is termianted
12-03 18:13:34.762+0900 D/STARTER ( 2895): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
12-03 18:13:34.762+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 16574
12-03 18:13:34.762+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 0
12-03 18:13:34.782+0900 D/APP_CORE(16772): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:13:34.792+0900 D/LAUNCH  (16772): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
12-03 18:13:34.792+0900 D/APP_CORE(16772): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
12-03 18:13:35.052+0900 E/RESOURCED( 2897): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
12-03 18:13:35.222+0900 D/AUL_AMD ( 2790): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.ddrgame /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:35.222+0900 D/RUA     ( 2790): rua.c: rua_add_history(179) > rua_add_history start
12-03 18:13:35.232+0900 D/RUA     ( 2790): rua.c: rua_add_history(247) > rua_add_history ok
12-03 18:13:35.762+0900 D/AUL_PAD (16775): launchpad_loader.c: main(588) > sleeping 1 sec...
12-03 18:13:35.762+0900 D/AUL_PAD (16775): preload.h: __preload_init(52) > max_cmdline_size = 1053
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8e81760
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(69) > get pre-initialization function
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(73) > get shutdown function
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8e81a40
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8e83640
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(69) > get pre-initialization function
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preload.h: __preload_init(73) > get shutdown function
12-03 18:13:35.772+0900 D/AUL_PAD (16775): preexec.h: __preexec_init(76) > preexec start
12-03 18:13:35.772+0900 D/AUL_PAD (16775): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
12-03 18:13:35.772+0900 D/AUL     (16775): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
12-03 18:13:35.772+0900 D/AUL     (16775): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
12-03 18:13:35.772+0900 D/AUL     (16775): process_pool.c: __connect_to_launchpad(132) > send(16775) : 4
12-03 18:13:35.772+0900 D/AUL     (16775): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
12-03 18:13:35.772+0900 D/AUL_PAD ( 2959): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 16775
12-03 18:13:35.852+0900 D/AUL_PAD (16775): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
12-03 18:13:35.862+0900 D/AUL_PAD (16775): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
12-03 18:13:35.862+0900 D/AUL_PAD (16775): launchpad_loader.c: main(693) > [candidate] ecore handler add
12-03 18:13:35.862+0900 D/AUL_PAD (16775): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
12-03 18:13:36.122+0900 D/APP_CORE( 2964): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
12-03 18:13:36.122+0900 I/APP_CORE( 2964): appcore-efl.c: __do_app(496) > [APP 2964] Event: MEM_FLUSH State: PAUSED
12-03 18:13:36.122+0900 D/APP_CORE( 2964): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
12-03 18:13:36.122+0900 D/APP_CORE( 2964): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2964
12-03 18:13:36.122+0900 D/APP_CORE( 2964): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
12-03 18:13:36.122+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2964
12-03 18:13:37.812+0900 E/EFL     (16772): eldbus<16772> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-ctPqBvoNOD: Connection refused
12-03 18:13:37.812+0900 E/EFL     (16772): <16772> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
12-03 18:13:37.812+0900 E/EFL     (16772): elementary<16772> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
12-03 18:13:37.812+0900 D/APP_CORE(16772): appcore.c: __aul_handler(587) > [APP 16772]     AUL event: AUL_START
12-03 18:13:37.812+0900 I/APP_CORE(16772): appcore-efl.c: __do_app(496) > [APP 16772] Event: RESET State: CREATED
12-03 18:13:37.812+0900 D/APP_CORE(16772): appcore-efl.c: __do_app(527) > [APP 16772] RESET
12-03 18:13:37.812+0900 D/LAUNCH  (16772): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
12-03 18:13:37.812+0900 D/APP_CORE(16772): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
12-03 18:13:37.812+0900 D/APP_CORE(16772): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
12-03 18:13:37.812+0900 E/SYSPOPUP(16772): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
12-03 18:13:37.812+0900 E/SYSPOPUP(16772): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
12-03 18:13:37.812+0900 E/SYSPOPUP(16772): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
12-03 18:13:37.812+0900 D/LAUNCH  (16772): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
12-03 18:13:37.812+0900 D/APP_CORE(16772): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
12-03 18:13:37.912+0900 D/AUL     (16772): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
12-03 18:13:37.912+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(838) > __request_handler: 22
12-03 18:13:37.912+0900 W/AUL_AMD ( 2790): amd_request.c: __request_handler(1056) > app status : 5
12-03 18:13:37.912+0900 D/AUL_AMD ( 2790): amd_status.c: _status_update_app_info_list(456) > pid(16772) status(5)
12-03 18:13:37.912+0900 D/APP_CORE(16772): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
12-03 18:13:37.912+0900 E/EFL     (16772): eo<16772> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
12-03 18:13:37.912+0900 E/EFL     (16772): eo<16772> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
12-03 18:13:38.732+0900 D/AUL_AMD ( 2790): amd_status.c: _status_update_app_info_list(456) > pid(16574) status(4)
12-03 18:13:40.462+0900 E/PKGMGR_SERVER(16835): pkgmgr-server.c: main(2209) > package manager server start
12-03 18:13:40.462+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
12-03 18:13:40.462+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
12-03 18:13:40.472+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
12-03 18:13:40.472+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
12-03 18:13:40.482+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
12-03 18:13:40.482+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.1062
12-03 18:13:40.482+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 16833
12-03 18:13:40.482+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 16833
12-03 18:13:40.482+0900 D/PKGMGR  (16835): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.ddrgame_2020643075, 14, tpk, org.example.ddrgame, , host)
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.ddrgame_2020643075] [14] [tpk] [org.example.ddrgame] [] [] [host]
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: queue_job(1884) > child forked [16838] for request type [14]
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: queue_job(2126) > parent exit
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16838): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
12-03 18:13:40.482+0900 D/PKGMGR_SERVER(16838): pkgmgr-server.c: queue_job(2057) > kill/check request
12-03 18:13:40.482+0900 D/PKGMGR  (16833): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
12-03 18:13:40.482+0900 D/PKGMGR  (16833): . 
12-03 18:13:40.482+0900 E/PKGMGR  (16833): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.ddrgame, -1]
12-03 18:13:40.492+0900 D/PKGMGR_SERVER(16838): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
12-03 18:13:40.492+0900 D/AUL     (16838): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
12-03 18:13:40.492+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(838) > __request_handler: 14
12-03 18:13:40.502+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.ddrgame : -1
12-03 18:13:40.502+0900 W/AUL_AMD ( 2790): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
12-03 18:13:40.502+0900 D/PKGMGR_SERVER(16838): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.ddrgame)
12-03 18:13:40.502+0900 D/PKGMGR_SERVER(16838): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.ddrgame, *) is ok.
12-03 18:13:40.502+0900 D/PKGMGR_SERVER(16835): pkgmgr-server.c: sighandler(387) > child exit [16838]
12-03 18:13:40.502+0900 E/PKGMGR_SERVER(16835): pkgmgr-server.c: sighandler(402) > child NORMAL exit [16838]
12-03 18:13:42.171+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 18:13:42.171+0900 D/AUL_AMD ( 2790): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 18:13:42.171+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 18:13:42.171+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 18:13:42.171+0900 I/AUL     ( 2790): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
12-03 18:13:42.171+0900 D/AUL     ( 2790): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 16885, pid = 16887
12-03 18:13:42.171+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:13:42.171+0900 D/PKGMGR_INFO( 2790): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:13:42.181+0900 I/AUL     ( 2790): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
12-03 18:13:42.181+0900 E/AUL_AMD ( 2790): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
12-03 18:13:42.181+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2233) > caller pid : 16887
12-03 18:13:42.181+0900 E/AUL_AMD ( 2790): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
12-03 18:13:42.181+0900 W/AUL_AMD ( 2790): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 18:13:42.181+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2648) > process_pool: false
12-03 18:13:42.181+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 18:13:42.181+0900 D/AUL_AMD ( 2790): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 18:13:42.181+0900 W/AUL_AMD ( 2790): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 18:13:42.181+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 18:13:42.181+0900 D/AUL_AMD ( 2790): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 18:13:42.181+0900 D/AUL     ( 2790): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 18:13:42.181+0900 W/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 18:13:42.181+0900 D/AUL     ( 2959): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 16775, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:42.181+0900 W/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 18:13:42.181+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 18:13:42.181+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 18:13:42.181+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
12-03 18:13:42.181+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 18:13:42.181+0900 D/AUL     (16775): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (16802) is sent.
12-03 18:13:42.181+0900 D/AUL     (16775): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 16802, signo: 10
12-03 18:13:42.181+0900 D/AUL     (16775): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NTY0MjIvMTg3Njg5AA==##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNjg4NwA=##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 8
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 18:13:42.181+0900 D/AUL_PAD (16775): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 18:13:42.191+0900 I/CAPI_APPFW_APPLICATION(16775): app_main.c: ui_app_main(788) > app_efl_main
12-03 18:13:42.191+0900 D/LAUNCH  (16775): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 18:13:42.191+0900 D/APP_CORE(16775): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:13:42.191+0900 D/APP_CORE(16775): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 18:13:42.191+0900 D/APP_CORE(16775): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:13:42.191+0900 D/APP_CORE(16775): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:13:42.201+0900 D/AUL     (16775): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:13:42.201+0900 D/APP_CORE(16775): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431f520
12-03 18:13:42.201+0900 D/LAUNCH  (16775): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 18:13:42.201+0900 I/CAPI_APPFW_APPLICATION(16775): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.241+0900 E/EFL     (16775): eo<16775> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:13:42.261+0900 W/CRASH_MANAGER(16760): worker.c: worker_job(1204) > 1116775646472148075642
