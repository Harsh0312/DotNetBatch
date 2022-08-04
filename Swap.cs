using System;
namespace SwapStr{
    class Swap{
        public static void Main(){
            string s1="p";
            string s2="q";
            driver d= new driver();
            d.methodbyref(ref s1,ref s2);
            Console.WriteLine("Value of s1 "+s1);
            Console.WriteLine("value of s2 "+s2);
        }
    }
    class driver{
        public void methodbyref(ref String a,ref String b){
            a="q";
            b="p";
        }
    }
}