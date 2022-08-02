using System;
using System.Text;
namespace buildAppend{
    class BuilderAppend{
        public static void Main(){
            StringBuilder addWord=new StringBuilder("Harsh");
            addWord.Append(" manoj");
            addWord.Append(" singh");
            Console.WriteLine(addWord);
        }
    }
}