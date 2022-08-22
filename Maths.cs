using System;
namespace math{
    class Operations{
        // public static int add (int a ,int b){
        //     return a+b;
        // }
        // public static int subtract(int a ,int b){
        //     return a-b;
        
        // }
        // public static int multiplication(int a ,int b){
        //     return a*b;
        // }
        public static void Main(string[] args){
            //Console.WriteLine("Add : "+ add(5,2));
            //Console.WriteLine("Subtract : "+ subtract(5,2));
            //Console.WriteLine("Multiplication : "+ multiplication(5,2));
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
        }
    }
}