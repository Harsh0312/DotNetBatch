using System;
 namespace Company{
    class Employee{
        // public string Emp_name;
        // public string Emp_address;
        public void print_name_address(String Emp_name,String Emp_address){
            Console.WriteLine("The Employee Name: "+ Emp_name +"\n"+ "The Employee address: "+Emp_address);
        }
    }
    class Program{
        public static void Main(){
            Employee e= new Employee();
            Console.Write("Enter no. of Employees: ");
            int num= Convert.ToInt32(Console.ReadLine());
            while(num>0){
                Console.Write("Enter name of the employee: ");
                String Emp_name= Console.ReadLine();
                Console.Write("Enter andress of the employee: ");
                String Emp_address= Console.ReadLine();
                e.print_name_address(Emp_name,Emp_address);
                num--;
            }
        }
    }
 }