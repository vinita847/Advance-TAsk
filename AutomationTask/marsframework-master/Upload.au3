ControlFocus("Open","","Edit1")
WinWait("Open")
ControlSetText("Open","","Edit1", "V:\Notes.txt")
WinWait("Open")
ControlClick("Open", "&Open", "Button1")