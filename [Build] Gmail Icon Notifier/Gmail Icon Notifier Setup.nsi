; Script generated by the HM NIS Edit Script Wizard.
!include WordFunc.nsh
!insertmacro VersionCompare
!include LogicLib.nsh

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Google Icon Notifier"
!define PRODUCT_VERSION "0.8 (RC1)"
!define PRODUCT_PUBLISHER "William Randol"
!define PRODUCT_WEB_SITE "http://www.williamrandol.com/GmailIconNotifier.htm"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\Gmail Icon Notifier.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"
!define PRODUCT_STARTMENU_REGVAL "NSIS:StartMenuDir"

; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "GMailIns.ico"
!define MUI_UNICON "GMailDel.ico"

; Welcome page
!insertmacro MUI_PAGE_WELCOME

; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Start menu page
var ICONS_GROUP
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "Google Icon Notifier"
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "${PRODUCT_UNINST_ROOT_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "${PRODUCT_STARTMENU_REGVAL}"
!insertmacro MUI_PAGE_STARTMENU Application $ICONS_GROUP
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\Gmail Icon Notifier.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Gmail Icon Notifier Setup.exe"
InstallDir "$PROGRAMFILES64\Gmail Icon Notifier"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Var InstallDotNET

Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY

  ; Check .NET version
  StrCpy $InstallDotNET "No"
  Call GetDotNETVersion
  Pop $0

  ${If} $0 == "not found"
        StrCpy $InstallDotNET "Yes"
  	MessageBox MB_OK|MB_ICONINFORMATION "${PRODUCT_NAME} requires that the .NET Framework 2.0 is installed. The .NET Framework will be downloaded and installed automatically during installation of ${PRODUCT_NAME}."
   	Return
  ${EndIf}

  StrCpy $0 $0 "" 1 # skip "v"

  ${VersionCompare} $0 "2.0" $1
  ${If} $1 == 2
        StrCpy $InstallDotNET "Yes"
  	MessageBox MB_OK|MB_ICONINFORMATION "${PRODUCT_NAME} requires that the .NET Framework 2.0 is installed. The .NET Framework will be downloaded and installed automatically during installation of ${PRODUCT_NAME}."
   	Return
  ${EndIf}
FunctionEnd

Function .onInstSuccess
         ExecWait "$InstDir\Install.exe"
FunctionEnd

Function GetDotNETVersion
	Push $0
	Push $1

	System::Call "mscoree::GetCORVersion(w .r0, i ${NSIS_MAX_STRLEN}, *i) i .r1"
	StrCmp $1 "error" 0 +2
	StrCpy $0 "not found"

	Pop $1
	Exch $0
FunctionEnd

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer

  ; Get .NET if required
  ${If} $InstallDotNET == "Yes"
     SetDetailsView hide
     inetc::get /caption "Downloading .NET Framework 2.0" /canceltext "Cancel" "http://www.williamrandol.com/dotnetfx.exe" "$INSTDIR\dotnetfx.exe" /end
     Pop $1

     ${If} $1 != "OK"
           Delete "$INSTDIR\dotnetfx.exe"
           Abort "Installation cancelled."
     ${EndIf}

     ExecWait "$INSTDIR\dotnetfx.exe"
     Delete "$INSTDIR\dotnetfx.exe"

     SetDetailsView show
  ${EndIf}

  SetOutPath "$SENDTO"
  File "Gmail Recipient.sendgmail"
  SetOutPath "$INSTDIR"
  File "Interop.Shell32.dll"
  File "GINCommonControls.dll"
  File "Google.GData.AccessControl.dll"
  File "Google.GData.Apps.dll"
  File "Google.GData.Client.dll"
  File "Google.GData.Contacts.dll"
  File "Google.GData.Extensions.dll"
  File "Gmail Icon Notifier.exe"
  File "Gmail Integration Helper.exe"
  File "Gmail Registration Helper.exe"
  File "Gmail.ico"
  
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Interop.Shell32.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\GINCommonControls.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.AccessControl.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Apps.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Client.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Contacts.dll" /silent /codebase'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Extensions.dll" /silent /codebase'

  ;Delete "$APPDATA\GIN\accounts.xml"

; Regstry
  SetRegView 64
  WriteRegStr HKCR "Gmail Recipient" "" "Gmail Recipient"
  WriteRegStr HKCR "Gmail Recipient" "NeverShowExt" ""
  WriteRegStr HKCR "Gmail Recipient\CLSID" "" "{7b64789d-dd84-4698-9e69-0ee0313ab7fd}"
  WriteRegStr HKCR "Gmail Recipient\DefaultIcon" "" '"$INSTDIR\Gmail.ico"';
  WriteRegStr HKCR "Gmail Recipient\shell" "" ""
  WriteRegStr HKCR "Gmail Recipient\shell\open" "" ""
  WriteRegStr HKCR "Gmail Recipient\shell\open\DropTarget" "clsid" "{7b64789d-dd84-4698-9e69-0ee0313ab7fd}"
  WriteRegStr HKCR "Gmail Recipient\shellex" "" ""
  WriteRegStr HKCR "Gmail Recipient\shellex\DropHandler" "" "{7b64789d-dd84-4698-9e69-0ee0313ab7fd}"
  WriteRegStr HKCR ".sendgmail" "" "Gmail Recipient"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}" "" "Gmail Recipient"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}" "NeverShowExt" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}" "FriendlyTypeName" "Gmail Recipient"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\Implemented Categories" "" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\Implemented Categories\{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}" "" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "" "mscoree.dll"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "ThreadingModel" "Both"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "Class" "Gmail_Integration_Helper.program"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "Assembly" "Gmail Integration Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=dddc8de709388763"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "RuntimeVersion" "v2.0.50727"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32" "CodeBase" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0" "" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0" "Class" "Gmail_Integration_Helper.program"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0" "Assembly" "Gmail Integration Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=dddc8de709388763"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0" "RuntimeVersion" "v2.0.50727"
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0" "CodeBase" ""
  WriteRegStr HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\ProgId" "" "Gmail Recipient"
  WriteRegStr HKCR "mailto\DefaultIcon" "" '"$INSTDIR\Gmail.ico"'
  WriteRegStr HKCR "mailto\shell\open\command" "" '"$INSTDIR\Gmail Integration Helper.exe" %1'

  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail" "" "Google Gmail"
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\DefaultIcon" "" '"$INSTDIR\Gmail.ico"'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\shell\open\command" "" '"$INSTDIR\Gmail Integration Helper.exe"'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto" "" "URL:MailTo Protocol"
  WriteRegBin HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto" "EditFlags" "02000000"
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto" "URL Protocol" ""
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto\DefaultIcon" "" '"$INSTDIR\Gmail.ico"'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto\shell\open" "" "Google Gmail"
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\Protocols\mailto\shell\open\command" "" '"$INSTDIR\Gmail Integration Helper.exe" %1'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\InstallInfo" "HideIconsCommand" '"$INSTDIR\Gmail Registration Helper.exe" -hideIcons'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\InstallInfo" "ReinstallCommand" '"$INSTDIR\Gmail Registration Helper.exe" -reinstall'
  WriteRegStr HKLM "Software\Clients\Mail\Google Gmail\InstallInfo" "ShowIconsCommand" '"$INSTDIR\Gmail Registration Helper.exe" -showIcons'
  WriteRegDWORD HKLM "Software\Clients\Mail\Google Gmail\InstallInfo" "IconsVisible" "0x00000001"
  WriteRegStr HKLM "Software\Clients\mail" "" "Google Gmail"

  WriteRegStr HKLM "Software\Google Gmail" "installFolder" "$INSTDIR"
  WriteRegStr HKLM "Software\Google Gmail" "smFolder" "$SMPROGRAMS\$ICONS_GROUP"
  WriteRegStr HKLM "Software\Google Gmail" "quickLink" "$QUICKLAUNCH\Google Gmail.lnk"
  WriteRegStr HKLM "Software\Google Gmail" "dtLink" "$DESKTOP\Google Icon Notifier.lnk"

  WriteRegStr HKCU "Software\Google Gmail" "usePrev" "false"
  WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Run" "Gmail Icon Notifier" '"$INSTDIR\Gmail Icon Notifier.exe"'


; Shortcuts
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  CreateDirectory "$SMPROGRAMS\$ICONS_GROUP"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\Google Icon Notifier.lnk" "$INSTDIR\Gmail Icon Notifier.exe" "" "$INSTDIR\Gmail Icon Notifier.exe" 0 SW_SHOWNORMAL "" "Monitor Your Gmail Inbox"
  CreateShortCut "$DESKTOP\Google Icon Notifier.lnk" "$INSTDIR\Gmail Icon Notifier.exe" "" "$INSTDIR\Gmail Icon Notifier.exe" 0 SW_SHOWNORMAL "" "Start the Gmail Icon Notifier"
  CreateShortCut "$QUICKLAUNCH\Google Gmail.lnk" "$INSTDIR\Gmail Integration Helper.exe" "" "$INSTDIR\Gmail Integration Helper.exe" 0 SW_SHOWNORMAL "" "Open Gmail"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -AdditionalIcons
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url" "" "$INSTDIR\Gmail Integration Helper.exe" 0 SW_SHOWNORMAL "" "Visit ${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Uninstall.lnk" "$INSTDIR\${PRODUCT_NAME} Uninstall.exe" "" "$INSTDIR\${PRODUCT_NAME} Uninstall.exe" 0 SW_SHOWNORMAL "" "Uninstall Gmail Icon Notifier"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\${PRODUCT_NAME} Uninstall.exe"
  SetRegView 32
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" '"$INSTDIR\Gmail Icon Notifier.exe"'
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\${PRODUCT_NAME} Uninstall.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\Gmail Icon Notifier.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
  SetRegView 64
  SetOutPath "$INSTDIR"
  Exec '"$INSTDIR\Gmail Registration Helper.exe"'
  Exec '"$INSTDIR\Gmail Registration Helper.exe" -reinstall'
SectionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  !insertmacro MUI_STARTMENU_GETFOLDER "Application" $ICONS_GROUP
  SetRegView 32
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  SetRegView 64
  DeleteRegKey HKCR "CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}"
  DeleteRegKey HKCR "Gmail Recipient"
  DeleteRegKey HKCR ".sendgmail"
  DeleteRegKey HKLM "Software\Clients\Mail\Google Gmail"
  DeleteRegKey HKLM "Software\Google Gmail"
  DeleteRegKey HKCU "Software\Google Gmail"
  DeleteRegValue HKCU "Software\Microsoft\Windows\CurrentVersion\UnreadMail" "Google Gmail"
  DeleteRegKey HKCU "Software\Microsoft\Windows\CurrentVersion\UnreadMail\Google Gmail"
  WriteRegStr HKCU "Software\Clients\mail" "" ""

  Delete "$INSTDIR\Gmail.ico"
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\${PRODUCT_NAME} Uninstall.exe"
  Delete "$INSTDIR\Gmail Registration Helper.exe"
  Delete "$INSTDIR\Gmail Integration Helper.exe"
  Delete "$INSTDIR\Gmail Icon Notifier.exe"
  Delete "$INSTDIR"
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Interop.Shell32.dll" /unregister /silent'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\GINCommonControls.dll" /unregister /silent'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.AccessControl.dll" /unregister /silent'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Apps.dll" /unregister /silent'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Contacts.dll" /unregister /silent'
  ;Exec '"$WINDIR\Microsoft.NET\Framework\v2.0.50727\RegAsm.exe" "$SYSDIR\Google.GData.Extensions.dll" /unregister /silent'
  Delete "$INSTDIR\Interop.Shell32.dll"
  Delete "$INSTDIR\GINCommonControls.dll"
  Delete "$INSTDIR\Google.GData.AccessControl.dll"
  Delete "$INSTDIR\Google.GData.Apps.dll"
  Delete "$INSTDIR\Google.GData.Client.dll"
  Delete "$INSTDIR\Google.GData.Contacts.dll"
  Delete "$INSTDIR\Google.GData.Extensions.dll"

  Delete "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Uninstall.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Website.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\Google Icon Notifier.lnk"
  Delete "$QUICKLAUNCH\Google Gmail.lnk"
  Delete "$DESKTOP\Google Icon Notifier.lnk"
  Delete "$SENDTO\Gmail Recipient.sendgmail"


  RMDir "$SMPROGRAMS\$ICONS_GROUP"
  RMDir "$INSTDIR"

  SetAutoClose true
SectionEnd