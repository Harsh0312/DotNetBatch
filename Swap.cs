using System;
namespace SwapStr{
    class Swap{
        public static void Main(){
            string a="p";
            string b="q";
            driver d= new driver();
            d.methodbyref(ref a,ref b);
            Console.WriteLine("Value of a "+a);
            Console.WriteLine("value of b "+b);
        }
    }
    class driver{
        public void methodbyref(ref String a,ref String b){
            a="q";
            b="p";
        }
    }
}