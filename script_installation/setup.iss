[Setup]
AppName=SI Pendataan Berkas Perusahaan
AppVerName=SI Pendataan Berkas Perusahaan Versi 1.0.0
AppPublisher=Kelompok 7
AppCopyright=Copyright © 2021. Kelompok 7
DefaultDirName={pf}\SI Pendata Berkas
DefaultGroupName=SI Berkas
OutputDir=file setup
OutputBaseFilename=SetupSIPendataanBerkas
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\SIPendataanBerkas.exe,0
UninstallDisplayName=SI Pendataan Berkas Perusahaan
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico

[Languages]
Name: ina; MessagesFile: Indonesian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: "Debug\SI Berkas Perusahaan.exe"; DestDir: {app}; Flags: ignoreversion
Source: "Debug\SI Berkas Perusahaan.exe.config"; DestDir: {app}; Flags: ignoreversion
Source: Debug\Database\SiPendataanBerkas.db; DestDir: {app}\Database; Flags: ignoreversion

; file-file pendukung
Source: Debug\System.Data.SQLite.dll; DestDir: {app}; Flags: ignoreversion
Source: Debug\x64\SQLite.Interop.dll; DestDir: {app}\x64; Flags: ignoreversion
Source: Debug\x86\SQLite.Interop.dll; DestDir: {app}\x86; Flags: ignoreversion

Source: book.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: "{group}\SI Pendataan Berkas Perusahaan"; Filename: "{app}\SI Berkas Perusahaan.exe"; WorkingDir: {app}; IconFilename: {app}\book.ico
Name: "{userdesktop}\SI Pendataan Berkas Perusahaan"; Filename: "{app}\SI Berkas Perusahaan.exe"; WorkingDir: {app}; IconFilename: {app}\book.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\SI Berkas"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue