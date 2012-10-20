; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Gmail Icon Notifier Patcher"
!define PRODUCT_VERSION "1.0"
!define PRODUCT_PUBLISHER "William Randol"
!define PRODUCT_WEB_SITE "http://www.williamrandol.com"

; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "GMailIns.ico"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!insertmacro MUI_PAGE_FINISH

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Gmail Icon Notifier Patcher.exe"
InstallDir "$PROGRAMFILES64\Gmail Icon Notifier"
ShowInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  MessageBox MB_YESNO|MB_ICONEXCLAMATION "This patcher can remove your account settings.$\n$\nWould you like to remove your account settings now?" IDYES true IDNO false
  true:
    Delete "$APPDATA\GIN\accounts.xml"
    Goto next
  false:
    
  next:
  File "Gmail Icon Notifier.exe"
SectionEnd

Section -Post
  Exec "$INSTDIR\Gmail Icon Notifier.exe"
SectionEnd