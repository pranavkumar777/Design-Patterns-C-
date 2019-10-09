

using System;

namespace BuilderPattern
{
    //product class - model
    class LaptopModel
    {
        public string name { get; set; }
        public string display { get; set; }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(display);
        }

    }
    interface Ibuilder
    {
        void model();
        void display();
    }

    //concretebuilder class
    class GamingLaptop : Ibuilder
    {
        LaptopModel laptop = new LaptopModel();
        public void display()
        {
            laptop.display = "HD Display";
        }

        public void model()
        {
            laptop.name = "G1235P";
            laptop.print();
        }
        
    }

    //concretebuilder class
    class NormalLaptop : Ibuilder
    {
        LaptopModel laptop = new LaptopModel();

        public void display()
        {
            laptop.display = "Normal Display";

        }

        public void model()
        {
            laptop.name = "NL1235P";
            laptop.print();

        }

    }

    //director class
    class Builder
    {
       public void build(Ibuilder builder)
        {
            builder.display();
            builder.model();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            Ibuilder normalLaptopBuilder= new NormalLaptop();
            builder.build(normalLaptopBuilder);


            Ibuilder gamingLaptopBuilder = new GamingLaptop();
            builder.build(gamingLaptopBuilder);
            Console.Read();
        }
    }
}
