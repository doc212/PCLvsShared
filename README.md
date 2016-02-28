This solution illustrates the difference between a PCL and a shared project.

* The shared project project Shared contains a single class that return a simple array of XmlSerializer
* Each project LibDroid, LibWin and LibPCL:
   * reference the shared project without adding anything else
   * generate an assembly named LibWin.dll

Everything builds to /bin/Debug

* Go in /bin/Debug and run WinConsole.exe : it works as expected
* replace LibWin.dll with the one from LibDroid: you get a runtime exception
* replace LibWin.dll with the one from LibPCL : it works


So even though XmlSerializer does exist in Android (with can build LibDroid), it generates a dll that cannot be used
by a Windows app.

So basically, a shared project is a way to share *code* whereas a PCL is a way to share *dll*.
