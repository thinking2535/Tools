svn update ..\..\..\Server\Server

xcopy ..\..\..\Server\Include\x64\Rso\*.prt .\Rso\ /Y /S
xcopy ..\..\..\Server\Server\Common\Source\*.prt .\GameServer\Common /Y /S
xcopy ..\..\..\Server\Server\Common\Source\*.cs .\GameServer\Common /Y /S

copy ..\..\..\Server\Bin\Rso\ProtoGen\x64\ProtoGen_sMTd.exe . /Y
