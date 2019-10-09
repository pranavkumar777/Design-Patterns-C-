using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

  
        // 'IPrototype' interface
        public interface IEmployee
        {
        
            IEmployee ShallowClone();
        object DeepClone();
        }

        // 'ConcretePrototype1' class implements IPrototype interface
        public class PermanentEmployee : IEmployee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string EmploymentType { get; set; }

        public PermanentEmployee()
            {
            }

        public PermanentEmployee(string name, int age, string employment)
        {
            this.Name = name;
            this.EmploymentType = employment;
            this.Age = age;

        }
        
        // Implement shallow cloning method
            public IEmployee ShallowClone()
            {
           
                return this.MemberwiseClone() as IEmployee;          
            }

            public object DeepClone()
            {

            PermanentEmployee permanentEmployee = new PermanentEmployee(this.Name,this.Age,this.EmploymentType);
            return permanentEmployee;

        }
    }

    //public class TemporaryEmployee : IEmployee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string EmploymentType { get; set; }

    //    Implement shallow cloning method
    //        public IEmployee ShallowClone()
    //    {
    //        Shallow Copy
    //            return this.MemberwiseClone() as IEmployee;

    //        Deep Copy
    //             Implement Memberwise clone method for every reference type object
    //             return ..
    //        }
    //}

    class Program
        {
            static void Main(string[] args)
            {
                PermanentEmployee permanentEmployee = new PermanentEmployee();
                permanentEmployee.Name = "Sam";
                permanentEmployee.Age = 25;
                permanentEmployee.EmploymentType = "Permanent";
            
                PermanentEmployee permanentEmployeeClone = (PermanentEmployee)permanentEmployee.ShallowClone();
                permanentEmployeeClone.Name = "Tom";
                permanentEmployeeClone.Age = 30;

                PermanentEmployee p =(PermanentEmployee) permanentEmployee.DeepClone();
                p.Name = "Kim";
                p.Age = 35;

                Console.WriteLine("Permanent Employee Details");
                Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.EmploymentType);

                Console.WriteLine("Cloned Permanent Employee Details");
                Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployeeClone.Name, permanentEmployeeClone.Age, permanentEmployeeClone.EmploymentType);

            Console.WriteLine("Cloned Permanent Employee Details");
            Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", p.Name, p.Age, p.EmploymentType);



            Console.ReadLine();
            }
        }
    }

