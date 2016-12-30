buildtest.ps1 does the following:
Build project based on configuration(QA, Stage, Debug, etc)
Package 
Deploy in a share

Syntax:
.\buildtest.ps1 <SOLUTION> <ENVNAME> <SOURCE> <DEST> <PACKAGE>
Example command:
.\buildtest.ps1 .\MusicStore.sln Stage C:\WebSite \\cwautomation01\vagrant C:\WebSite.zip
