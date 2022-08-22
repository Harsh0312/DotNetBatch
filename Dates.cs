using System;
namespace  DifferenceTime{
    class DateSpan{
        public static void Main(){
        DateTime d1= new DateTime(2022,08,5,11,11,11);
        DateTime d2= new DateTime(2022,08,10,11,11,11);
        DifferenceTime.Difference.Diff(d1,d2);
        }
    }
    class Difference{
        public static void Diff(DateTime t1,DateTime t2){
            TimeSpan interval=t2-t1;
            Console.WriteLine("The Difference is  " + interval);
        }
    }
}