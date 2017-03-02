S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: ddrgame
PID: 5011
Date: 2016-12-03 18:23:17+0900
Executable File Path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbf8f2fdc, esi = 0x00000001
ebp = 0xbf8f3128, esp = 0xbf8f2f28
eax = 0xbf8f2fdc, ebx = 0xb3801160
ecx = 0x00000001, edx = 0xbf8f2fdc
eip = 0xb6d21df9

Memory Information
MemTotal:      123 KB
MemFree:        39 KB
Buffers:         5 KB
Cached:     147096 KB
VmPeak:      80032 KB
VmSize:      80032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15800 KB
VmRSS:       15800 KB
VmData:      19976 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33452 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5011 TID = 5011
5011 5012 5193 

Maps Information
b2cc0000 b2cca000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cd0000 b2cdc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cdd000 b2cfe000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d03000 b2d04000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d05000 b2d0a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d0b000 b2d0c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d0d000 b2d0f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d10000 b2d1c000 r-xp /usr/lib/libdrm.so.2.4.0
b2d1d000 b2d20000 r-xp /usr/lib/libdri2.so.0.0.0
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
b37f1000 b37f3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37f4000 b37f5000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37f6000 b37fc000 r-xp /usr/lib/libcapi-system-sensor.so.0.2.0
b37fd000 b3801000 r-xp /opt/usr/apps/org.example.ddrgame/bin/ddrgame
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

Callstack Information (PID:5011)
Call Stack Count: 8
 0: (0xb6d21df9) [/lib/libc.so.6] + 0x8cdf9
 1: app_create + 0x2c (0xb37fe64c) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x164c
 2: (0xb778361b) [/usr/lib/libcapi-appfw-application.so.0] + 0x261b
 3: appcore_efl_main + 0x327 (0xb778ac27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb7783c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
 5: main + 0x29e (0xb37fe5be) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x15be
 6: win_delete_request_cb + 0x8 (0xb77bf148) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0xb77bf148
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
d3m3Z1B5caCqwSPr72oKPSI4jSkvrAC5W7EHx16M818aG4tQkXIUBhDrtSmH6dFOdt8zGq2fanj1sETfUmXAeLGE7OQYcEb2SoWGXR75Ytfp1LAw/L3luuG/kbzBcrZt1Cv05jfCP575eope6p5p80Gl0tieXyPYhSLVTLwhEdWx18CMaC7IXQo2Bm+JdjDH0Ruh/vTRnjFtmVB+nBOZNVzMHNOPUVFKSgysX/+PlM4jBTvbaTnPCZUkC/O75tYIpwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBw95ibcuAiKpAEqBMyTZtOf0okhSi9NYfs/AFIPLH5REnhtQkPmKsvDp21OSdzrFEL42rV94K98QChD9tGO6Mwp1ZHM3No7/PLC3EelOwmn4dr3KPGdjvQNSwKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
12-03 18:23:15.375+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.ddrgame/author-signature.xml) succeed.
12-03 18:23:15.375+0900 D/rpm-installer( 5137): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 
12-03 18:23:15.375+0900 D/rpm-installer( 5137): kZvQzyk/M6WxsRmbNs1OvQ/jyOTIrh1anrwemINFBJQ07cXtz+sEDbMUMNIREOzeMbsPFEMmSU/3
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 5tI9gCP6OKXWnck6kvPdXMP2UdK9EBY1LKFDWoqj+6Vld/qyDT+7cOJOkGa/fLIhn/XSlW10hkYR
12-03 18:23:15.375+0900 D/rpm-installer( 5137): yb3I2YrU1eIpLn3oIMM=
12-03 18:23:15.375+0900 D/rpm-installer( 5137): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 
12-03 18:23:15.375+0900 D/rpm-installer( 5137): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
12-03 18:23:15.375+0900 D/rpm-installer( 5137): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
12-03 18:23:15.375+0900 D/rpm-installer( 5137): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
12-03 18:23:15.375+0900 D/rpm-installer( 5137): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
12-03 18:23:15.375+0900 D/rpm-installer( 5137): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
12-03 18:23:15.375+0900 D/rpm-installer( 5137): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
12-03 18:23:15.375+0900 D/rpm-installer( 5137): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
12-03 18:23:15.375+0900 D/rpm-installer( 5137): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
12-03 18:23:15.375+0900 D/rpm-installer( 5137): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
12-03 18:23:15.375+0900 D/rpm-installer( 5137): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
12-03 18:23:15.375+0900 D/rpm-installer( 5137): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
12-03 18:23:15.375+0900 D/rpm-installer( 5137): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 
12-03 18:23:15.375+0900 D/rpm-installer( 5137): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
12-03 18:23:15.375+0900 D/rpm-installer( 5137): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
12-03 18:23:15.375+0900 D/rpm-installer( 5137): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
12-03 18:23:15.375+0900 D/rpm-installer( 5137): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
12-03 18:23:15.375+0900 D/rpm-installer( 5137): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
12-03 18:23:15.375+0900 D/rpm-installer( 5137): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
12-03 18:23:15.375+0900 D/rpm-installer( 5137): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
12-03 18:23:15.375+0900 D/rpm-installer( 5137): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
12-03 18:23:15.375+0900 D/rpm-installer( 5137): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
12-03 18:23:15.375+0900 D/rpm-installer( 5137): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
12-03 18:23:15.375+0900 D/rpm-installer( 5137): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
12-03 18:23:15.375+0900 D/rpm-installer( 5137): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
12-03 18:23:15.375+0900 D/rpm-installer( 5137): VhfnkHwPl
12-03 18:23:15.385+0900 D/CERT_SVC( 5137): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
12-03 18:23:15.385+0900 D/rpm-installer( 5137): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
12-03 18:23:15.385+0900 D/rpm-installer( 5137): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
12-03 18:23:15.385+0900 D/rpm-installer( 5137): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
12-03 18:23:15.395+0900 D/rpm-installer( 5137): rpm-installer.c: __ri_verify_file(336) > valid signature
12-03 18:23:15.395+0900 D/rpm-installer( 5137): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
12-03 18:23:15.395+0900 D/rpm-installer( 5137): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
12-03 18:23:15.395+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.ddrgame/signature1.xml) succeed.
12-03 18:23:15.395+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 18:23:15.395+0900 D/PKGMGR_INSTALLER( 5137): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[install_percent] value[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 18:23:15.395+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
12-03 18:23:15.395+0900 D/PKGMGR  ( 5132): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ddrgame] 60
12-03 18:23:15.395+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 18:23:15.395+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:install_percent val:60
12-03 18:23:15.395+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(install_percent), val(60)
12-03 18:23:15.395+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.ddrgame]
12-03 18:23:15.395+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 18:23:15.395+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[install_percent] val[60] pmsg[(null)]
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 16
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 16
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 1
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 4
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 4
12-03 18:23:15.395+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 4
12-03 18:23:15.405+0900 E/PKGMGR_CERT( 5137): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
12-03 18:23:15.405+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.ddrgame), result=[0]
12-03 18:23:15.405+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.ddrgame), result=[0]
12-03 18:23:15.405+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame, 5, _), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared, 5, _), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/res, 5, _), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/data, 2), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.ddrgame/shared/data], label=[$1$org.exam$aAnh6.J7RR0Vvi7oaShJf0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.ddrgame/shared/cache], label=[$1$org.exam$aAnh6.J7RR0Vvi7oaShJf0]
12-03 18:23:15.415+0900 E/rpm-installer( 5137): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [a+ff#XX4vz2m4AI3lzpSRp5k2z4=] for shared/trusted.
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/trusted, 1, a+ff#XX4vz2m4AI3lzpSRp5k2z4=), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/bin, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.415+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/data, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/lib, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/res, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/cache, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/tizen-manifest.xml, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/author-signature.xml, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/signature1.xml, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/share/packages/org.example.ddrgame.xml, 0, org.example.ddrgame), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.ddrgame] version set to [2.4] result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
12-03 18:23:15.425+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.ddrgame, 7), result=[0]
12-03 18:23:15.425+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 18:23:15.425+0900 D/PKGMGR_INSTALLER( 5137): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[install_percent] value[100]
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
12-03 18:23:15.425+0900 D/rpm-installer( 5137): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.ddrgame) is done.
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 18:23:15.425+0900 D/PKGMGR_INSTALLER( 5137): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[end] value[ok]
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5137), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5137), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5137): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
12-03 18:23:15.425+0900 D/PKGMGR  ( 5132): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.425+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ddrgame] 100
12-03 18:23:15.435+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 18:23:15.435+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(install_percent), val(100)
12-03 18:23:15.435+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.ddrgame]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[install_percent] val[100] pmsg[(null)]
12-03 18:23:15.435+0900 D/PKGMGR  ( 5132): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/ISF_PANEL_EFL( 3065): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.ddrgame event_type=UPDATE event_state=COMPLETED progress=100 error=0
12-03 18:23:15.435+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.ddrgame] ok
12-03 18:23:15.435+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.ddrgame], event_type[1]
12-03 18:23:15.435+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2802): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/AUL_AMD ( 2802): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.ddrgame), key(end), value(ok)
12-03 18:23:15.435+0900 W/AUL_AMD ( 2802): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
12-03 18:23:15.435+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.ddrgame]
12-03 18:23:15.435+0900 D/cluster-home( 2908): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.ddrgame]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[end] val[ok] pmsg[(null)]
12-03 18:23:15.435+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
12-03 18:23:15.435+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
12-03 18:23:15.435+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
12-03 18:23:15.435+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(end), val(ok)
12-03 18:23:15.435+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
12-03 18:23:15.435+0900 W/ISF_PANEL_EFL( 3065): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
12-03 18:23:15.435+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 18:23:15.435+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 18:23:15.435+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:install_percent val:100
12-03 18:23:15.435+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.435+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:end val:ok
12-03 18:23:15.445+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
12-03 18:23:15.445+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
12-03 18:23:15.445+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.ddrgame]
12-03 18:23:15.445+0900 D/AUL_AMD ( 2802): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.ddrgame, type:rpm
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
12-03 18:23:15.445+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_-1699566596], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.ddrgame]
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.ddrgame]
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.ddrgame]
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.ddrgame]
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.ddrgame] Name[ddrgame] Icon[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png] enable[1] system[0]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.ddrgame]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.ddrgame
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.ddrgame], name[ddrgame], menuId[1], isPreload[0] isPreload[0]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
12-03 18:23:15.445+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.ddrgame] Name[ddrgame] Icon[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png] enable[1] system[0]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [ddrgame]
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
12-03 18:23:15.445+0900 D/test-log( 2908): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png], New icon path[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png]!!!!!
12-03 18:23:15.445+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
12-03 18:23:15.695+0900 D/rpm-installer( 5137): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
12-03 18:23:15.695+0900 D/rpm-installer( 5137): rpm-appcore-intf.c: main(259) > ------------------------------------------------
12-03 18:23:15.695+0900 D/rpm-installer( 5137): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
12-03 18:23:15.695+0900 D/rpm-installer( 5137): rpm-appcore-intf.c: main(261) > ------------------------------------------------
12-03 18:23:15.695+0900 D/PKGMGR_SERVER( 5134): pkgmgr-server.c: sighandler(387) > child exit [5137]
12-03 18:23:15.695+0900 E/PKGMGR_SERVER( 5134): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5137]
12-03 18:23:16.765+0900 D/RESOURCED( 2896): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
12-03 18:23:16.765+0900 I/RESOURCED( 2896): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
12-03 18:23:16.765+0900 D/RESOURCED( 2896): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
12-03 18:23:16.765+0900 I/RESOURCED( 2896): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
12-03 18:23:16.765+0900 I/RESOURCED( 2896): logging.c: logging_save_to_storage(978) > storage cache is empty
12-03 18:23:16.785+0900 D/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(442) > pid(4821)
12-03 18:23:16.785+0900 W/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
12-03 18:23:16.785+0900 D/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(442) > pid(4821)
12-03 18:23:16.785+0900 W/AUL_AMD ( 2802): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 18:23:17.405+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 18:23:17.405+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 18:23:17.405+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
12-03 18:23:17.405+0900 D/AUL     ( 2802): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5187, pid = 5189
12-03 18:23:17.405+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:23:17.405+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 18:23:17.405+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
12-03 18:23:17.405+0900 E/AUL_AMD ( 2802): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
12-03 18:23:17.405+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2233) > caller pid : 5189
12-03 18:23:17.405+0900 E/AUL_AMD ( 2802): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
12-03 18:23:17.405+0900 W/AUL_AMD ( 2802): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2648) > process_pool: false
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 18:23:17.405+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 18:23:17.405+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 18:23:17.405+0900 D/AUL     ( 2802): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 18:23:17.405+0900 W/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 18:23:17.405+0900 D/AUL     ( 2960): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5011, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:23:17.405+0900 W/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 18:23:17.405+0900 D/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 18:23:17.405+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 18:23:17.405+0900 D/AUL     ( 5011): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5012) is sent.
12-03 18:23:17.405+0900 D/RESOURCED( 2896): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 18:23:17.405+0900 D/RESOURCED( 2896): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 18:23:17.415+0900 E/RESOURCED( 2896): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 18:23:17.415+0900 D/AUL     ( 5011): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5012, signo: 10
12-03 18:23:17.415+0900 D/AUL     ( 5011): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NTY5OTcvNDExOTUwAA==##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1MTg5AA==##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 8
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 18:23:17.415+0900 D/AUL_PAD ( 5011): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 18:23:17.415+0900 I/CAPI_APPFW_APPLICATION( 5011): app_main.c: ui_app_main(788) > app_efl_main
12-03 18:23:17.415+0900 D/LAUNCH  ( 5011): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 18:23:17.415+0900 D/APP_CORE( 5011): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 18:23:17.415+0900 D/APP_CORE( 5011): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 18:23:17.415+0900 D/APP_CORE( 5011): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 18:23:17.425+0900 D/APP_CORE( 5011): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 18:23:17.425+0900 D/AUL     ( 5011): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 18:23:17.425+0900 D/APP_CORE( 5011): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e3520
12-03 18:23:17.425+0900 D/LAUNCH  ( 5011): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 18:23:17.425+0900 I/CAPI_APPFW_APPLICATION( 5011): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 18:23:17.475+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.475+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.475+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.475+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.485+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.485+0900 E/EFL     ( 5011): eo<5011> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 18:23:17.515+0900 E/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 5011
12-03 18:23:17.515+0900 E/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 5011
12-03 18:23:17.515+0900 E/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
12-03 18:23:17.515+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5011, appid: org.example.ddrgame
12-03 18:23:17.515+0900 D/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 18:23:17.515+0900 E/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 18:23:17.515+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2700) > add app group info
12-03 18:23:17.515+0900 E/AUL     ( 2802): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
12-03 18:23:17.515+0900 D/AUL_AMD ( 2802): amd_status.c: _status_add_app_info_list(427) > pid(5011) appid(org.example.ddrgame) pkgid(org.example.ddrgame) comp(uiapp)
12-03 18:23:17.515+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.ddrgame, 5011
12-03 18:23:17.525+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.ddrgame with pkgname
12-03 18:23:17.525+0900 E/RESOURCED( 2896): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.ddrgame
12-03 18:23:17.525+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(888) > available memory = 323
12-03 18:23:17.545+0900 W/CRASH_MANAGER( 5194): worker.c: worker_job(1204) > 1105011646472148075699
