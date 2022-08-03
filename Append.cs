using System;
using System.Text;
namespace buildAppend{
    class BuilderAppend{
        public static void Main(){
            // StringBuilder addWord=new StringBuilder("Harsh");
            // addWord.Append(" manoj");
            // addWord.Append(" singh");
            // Console.WriteLine(addWord);
            String s1= "Harsh";
            String s2="Singh";
            StringBuilder s3= new StringBuilder("Abd");
            StringBuilder s4= new StringBuilder("def");
            Concatenation c= new Concatenation();
            c.Concat(s1,s2);
            Appendd a= new Appendd();
            a.Add(s3,s4);

        }
    }
    class Concatenation{
        public void Concat(String s1, String s2){
            Console.WriteLine(s1+s2);
        }
    }
    class Appendd{
        public void Add(StringBuilder s1, StringBuilder s2){
            Console.WriteLine(s1.Append(s2));

        }
    }
    }
