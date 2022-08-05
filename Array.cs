using System;
using System.Collections;
using System.Collections.Generic;
namespace Collectionss{
    class Program{
        public static void Main(){
            array a= new array();
            a.arr();
           arrList al=new arrList();
           al.arrrlist();
           LinkedList ll= new LinkedList();
           ll.LinkedListNUm();
        }
    }
    class array{
        public void arr(){
            int[] ar= {1,2,3,4,5};
            int m=int.MinValue;
           for (int i=0; i<ar.Length;i++){
                if (m<ar[i]){
                    m=ar[i];
                }
            }
            Console.WriteLine("the max value is :"+m);
        }
    
        
    }
    class arrList{
        public void arrrlist(){
        ArrayList myarr= new ArrayList();
        myarr.Add(3);
        myarr.Add(5);
        myarr.Add(2);
        myarr.Add(7);
        myarr.Add(4);
        int m = int.MinValue;
            foreach (int i in myarr)  {
                if (i >m) m = i;
            }
            System.Console.WriteLine("Largest number of ArrayList is: " + m);
        }
}
    }
    class LinkedList{
        public void LinkedListNUm(){
            LinkedList<int> myLL=  new LinkedList<int>();
            myLL.AddFirst(1);
            myLL.AddFirst(2);
            myLL.AddFirst(3);
            int m=int.MinValue;
            foreach(int i in myLL){
                if(i>m){
                    m=i;
                }
                
            }
            System.Console.WriteLine("the max value is "+m);
        }
    }

    
