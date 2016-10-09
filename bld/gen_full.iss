; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "TweetDuck"
#define MyAppPublisher "chylex"
#define MyAppURL "https://tweetduck.chylex.com"
#define MyAppExeName "TweetDuck.exe"

#define MyAppVersion GetFileVersion("..\bin\x86\Release\TweetDuck.exe")

[Setup]
AppId={{8C25A716-7E11-4AAD-9992-8B5D0C78AE06}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename={#MyAppName}
VersionInfoVersion={#MyAppVersion}
LicenseFile=.\Resources\LICENSE
SetupIconFile=.\Resources\icon.ico
UninstallDisplayName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression=lzma
SolidCompression=yes
InternalCompressLevel=max
MinVersion=0,6.1

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\bin\x86\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\x86\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: "*.xml,devtools_resources.pak,d3dcompiler_43.dll"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[InstallDelete]
Type: files; Name: "{app}\td-log.txt"

[UninstallDelete]
Type: files; Name: "{app}\debug.log"
Type: filesandordirs; Name: "{localappdata}\{#MyAppName}\Cache"
Type: filesandordirs; Name: "{localappdata}\{#MyAppName}\GPUCache"

[Code]
function TDGetNetFrameworkVersion: Cardinal; forward;

{ Check .NET Framework version on startup, ask user if they want to proceed if older than 4.5.2. }
function InitializeSetup: Boolean;
begin
  if TDGetNetFrameworkVersion() >= 379893 then
  begin
    Result := True;
    Exit;
  end;
  
  if (MsgBox('{#MyAppName} requires .NET Framework 4.5.2 or newer,'+#13+#10+'please download it from {#MyAppURL}'+#13+#10+#13+#10'Do you want to proceed with the setup anyway?', mbCriticalError, MB_YESNO or MB_DEFBUTTON2) = IDNO) then
  begin
    Result := False;
    Exit;
  end;
  
  Result := True;
end;

{ Ask user if they want to delete 'AppData\TweetDuck' and 'plugins' folders after uninstallation. }
procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
var ProfileDataFolder: String;
var PluginDataFolder: String;

begin
  if CurUninstallStep = usPostUninstall then
  begin
    ProfileDataFolder := ExpandConstant('{localappdata}\{#MyAppName}')
    PluginDataFolder := ExpandConstant('{app}\plugins')
    
    if (DirExists(ProfileDataFolder) or DirExists(PluginDataFolder)) and (MsgBox('Do you also want to delete your {#MyAppName} profile and plugins?', mbConfirmation, MB_YESNO or MB_DEFBUTTON2) = IDYES) then
    begin
      DelTree(ProfileDataFolder, True, True, True);
      DelTree(PluginDataFolder, True, True, True);
      DelTree(ExpandConstant('{app}'), True, False, False);
    end;
  end;
end;

{ Return DWORD value containing the build version of .NET Framework. }
function TDGetNetFrameworkVersion: Cardinal;
var FrameworkVersion: Cardinal;

begin
  if RegQueryDWordValue(HKEY_LOCAL_MACHINE, 'Software\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', FrameworkVersion) then
  begin
    Result := FrameworkVersion;
    Exit;
  end;
  
  Result := 0;
end;
