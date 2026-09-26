# NTSD and SOS: StopOnException

Test program for the SOS `!StopOnException` command. It throws `OutOfMemoryException` in a loop and a single `ArgumentException` on one iteration, so you can practice breaking only on the exception type you care about.

Originally published at [NTSD and SOS: StopOnException](https://blogs.msdn.microsoft.com/thottams/2009/01/15/ntsd-and-sos-stoponexception/) on the MSDN `thottams` blog.

## Building

```text
csc program.cs
program.exe
```

## Note

This is archived sample code from a blog post written years ago. It targets the .NET Framework / Visual Studio versions of that era and is kept here for reference.

