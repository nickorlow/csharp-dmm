using System;
 using System.Runtime.InteropServices;

    namespace DMM
    {
        public unsafe partial class Program
        {
            static void free(void* ptr)
            {
                NativeMemory.Free(ptr);
            }

            static int strlen(char* countme)
            {
                int i = 0;
                for (; *(countme + i) != '\0'; i++)
                {
                }

                return i;
            }

            static void printf(char* printme)
            {
                for (char* i = printme; *(i) != '\0'; i++)
                {
                    Console.Write(*i);
                }
            }

            static void* malloc(int length)
            {
                return NativeMemory.Alloc((nuint) length);
            }

            static void strcpy(char* dest, char* source)
            {
                for (int i = 0; *(source + i) != '\0'; i++)
                {
                    *(dest + i) = *(source + i);
                }
            }
        }
    }