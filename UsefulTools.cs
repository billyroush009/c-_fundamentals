using System;

namespace C_
{
    //static declaration prevents objects of this class from being created
    static class UsefulTools
    {
        public static void SayHi(string name){
            Console.WriteLine("Hello " + name);
        }
    }
}