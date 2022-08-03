 using System;
 using System.Collections;
 namespace shape{
    class Areas{
        public static void Main(){
                Rectangle r= new Rectangle();
                square s= new square();
                r.Area_rectangle(5,12);
                s.Area_square(4);
        }
    }
    class Rectangle{
        public void Area_rectangle(int length,int breadth){
            Console.WriteLine("Area of the rectangle: "+ (length*breadth));
        }
    }
    class square{
        public void Area_square(int side){
            Console.WriteLine("The area of Square :"+(side*side));
        }
    }
}