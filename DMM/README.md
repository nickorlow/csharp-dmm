# C# DMM
Dynamically allocate your memory in a garbage-collected language?

### Background
In .NET 6, Microsoft introduced the `NativeMemory` class which lets you allocate and free your own memory!

With this, I wrote a demo using unsafe C# code to write something that looks eerily similar to C.

This also supports AOT compilation meaning that you can compile directly to a native binary. How cool is that? If you're on MacOS, you can 
run the file located at `/DMM/DMM/DMM_osx64_binary` without having the .NET runtime installed!

### Trickery
Ok, so I did use _some_ trickery here but it was mostly just writing functions that C# doesnt have and creating functions
to hide the ugly and verbose function names C# has. Nothing that really defeats the purpose of DMM in C# but the trickery makes
it look more C-like. 

