using System;
namespace ArithmeticOperations{
    class Sum{
            public static int add(int a, int b){
                return a+b;
            }
    }
    class Subtract{
        public static int subtract(int a ,int b){
            return a-b;
        }

    }
    class Multiplication{
        public static int multiplication(int a,int b){
                return a*b;
        }
    }
    class Division{
        public static int division(int a,int b){
            return a/b;
        }

    }

    class Operations{
    public static void Main(string[] args) {
            Console.WriteLine("Addition of two Numbers : " + Sum.add(5,2));
            Console.WriteLine("Subtraction of two Numbers :" + Subtract.subtract(6,4));
            Console.WriteLine("Multiplication of two Numbers :" + Multiplication.multiplication(5,4));
            Console.WriteLine("Division of two Numbers : " + Division.division(4,2));
    }
    }
}