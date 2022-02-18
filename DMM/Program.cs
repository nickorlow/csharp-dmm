using System;

namespace DMM
{
    public unsafe partial class Program
    {
        public static void Main(string[] args)
        {
            // Disable Garbage Collection (Not Necessary)
            GC.TryStartNoGCRegion(1);
            
            Console.WriteLine("C# DMM");
            fixed (char* str2 = "This is a char Arr\n")
            {
                char* str = (char*) malloc(strlen(str2) + 1);
                strcpy(str, str2);
                *(str2 + 2) = 'a';
                *(str2 + 3) = 't';
                printf(str);
                printf(str2);
                
                free(str);
                
                // This line will cause a malloc error
                free(str2);
            }
        }
    }
}