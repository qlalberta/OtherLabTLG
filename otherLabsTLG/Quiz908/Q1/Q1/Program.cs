//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project1
//{
//    public class Vehicle
//    {
//        public string make;
//        public string model;
//        public string color;
//        public int yearBuilt;
//        public Vehicle(string make, string model, string color, int yearBuilt)
//        {
//            this.make = make;
//            this.model = model;
//            this.color = color;
//            this.yearBuilt = yearBuilt;
//        }
//        public void ShowCar()
//        {
//            Console.WriteLine("myProduct details:");
//            Console.WriteLine("myProduct.make = {0}", this.make);
//            Console.WriteLine("myProduct.model = {0}", this.model);
//            Console.WriteLine("myProduct.color = {0}", this.color);
//            Console.WriteLine("myProduct.yearBuilt = {0}", this.yearBuilt);
//            Console.WriteLine("My Car is a " + this.yearBuilt + " " + this.make + " " + this.model + " " + this.color + ".");
//            Console.WriteLine();
//        }
//    }


//    public class TestVehicle
//    {
//        static void Main(string[] args)
//        {
//            Vehicle myCar = new Vehicle("Toyota", "MR2", "black", 1995);
//            myCar.ShowCar();
//            Vehicle anotherCar = new Vehicle("Porsche", "Boxster", "red", 2000);
//            myCar = anotherCar;
//            myCar.ShowCar();

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    public class Vehicle
//    {
//        public string make;
//        public string model;
//        public string color;
//        public int yearBuilt;
//        public Vehicle(string make, string model, string color, int yearBuilt)
//        {
//            this.make = make;
//            this.model = model;
//            this.color = color;
//            this.yearBuilt = yearBuilt;
//        }
//        public void ShowCar()
//        {
//            Console.WriteLine("myProduct details:");
//            Console.WriteLine("myProduct.make = {0}", this.make);
//            Console.WriteLine("myProduct.model = {0}", this.model);
//            Console.WriteLine("myProduct.color = {0}", this.color);
//            Console.WriteLine("myProduct.yearBuilt = {0}", this.yearBuilt);
//            Console.WriteLine("My Car is a " + this.yearBuilt + " " + this.make + " " + this.model + " " + this.color + ".");
//            Console.WriteLine();
//        }
//    }


//    public class TestVehicle
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Please input the information of the first car:");            Vehicle myCar = GetCarInfo();
//            myCar.ShowCar();
//            Console.WriteLine("Please input the information of the second car:");
//            Vehicle anotherCar = GetCarInfo();
//            Console.WriteLine();
//            Console.WriteLine("Override the first car");
//            myCar = anotherCar;
//            myCar.ShowCar();
//            Vehicle GetCarInfo()
//            {
//                Console.WriteLine("Please input the make of the car: ");
//                string Make = Console.ReadLine();
//                Console.WriteLine("Please input the model of the car: ");
//                string Model = Console.ReadLine();
//                Console.WriteLine("Please input the color of the car: ");
//                string Color = Console.ReadLine();
//                Console.WriteLine("Please input the year of the car: ");
//                int yearBuilt = Convert.ToInt32(Console.ReadLine());
//                Vehicle Car = new Vehicle(Make, Model, Color, yearBuilt);
//                return Car;
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Vehicle
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;
        public Vehicle(string make, string model, string color, int yearBuilt)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.yearBuilt = yearBuilt;
        }
        public void ShowCar()
        {
            Console.WriteLine("myProduct details:");
            Console.WriteLine("myProduct.make = {0}", this.make);
            Console.WriteLine("myProduct.model = {0}", this.model);
            Console.WriteLine("myProduct.color = {0}", this.color);
            Console.WriteLine("myProduct.yearBuilt = {0}", this.yearBuilt);
            Console.WriteLine("My Car is a " + this.yearBuilt + " " + this.make + " " + this.model + " " + this.color + ".");
            Console.WriteLine();
        }
    }

    public class TestVehicle
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input the information of the first car:");
            Vehicle myCar = GetCarInfo();
            myCar.ShowCar();
            Console.WriteLine("Please input the information of the second car:");
            Vehicle anotherCar = GetCarInfo();
            Console.WriteLine();
            Console.WriteLine("Override the first car");
            myCar = anotherCar;
            myCar.ShowCar();

            Vehicle GetCarInfo()
            {
                Console.WriteLine("Please input the make of the car: ");
                string Make = Console.ReadLine();

                Console.WriteLine("Please input the model of the car: ");
                string Model = Console.ReadLine();

                Console.WriteLine("Please input the color of the car: ");
                string Color = Console.ReadLine();

                Console.WriteLine("Please input the year of the car: ");

                try
                {
                    int yearBuilt = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    do
                    {
                        Console.WriteLine("Please input the year of the car: ")
                                }
                    while (!int.TryParse(Convert.ToInt32(Console.ReadLine()), out value)

                    }
            }
            int yearBuilt = Convert.ToInt32(Console.ReadLine());
            Vehicle Car = new Vehicle(Make, Model, Color, yearBuilt);
            return Car;
        }
    }
}
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project4
//{
//    public class Vehicle
//    {
//        public string make;
//        public string model;
//        public string color;
//        public int yearBuilt;
//        public Vehicle(string make, string model, string color, int yearBuilt)
//        {
//            this.make = make;
//            this.model = model;
//            this.color = color;
//            this.yearBuilt = yearBuilt;
//        }
//        public void ShowCar()
//        {
//            Console.WriteLine("myProduct details:");
//            Console.WriteLine("myProduct.make = {0}", this.make);
//            Console.WriteLine("myProduct.model = {0}", this.model);
//            Console.WriteLine("myProduct.color = {0}", this.color);
//            Console.WriteLine("myProduct.yearBuilt = {0}", this.yearBuilt);
//            Console.WriteLine("My Car is a " + this.yearBuilt + " " + this.make + " " + this.model + " " + this.color + ".");
//            Console.WriteLine();
//        }
//    }

//    public class TestVehicle
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine
//                ("Please decide how many cars you want to enter: ");
//            int count;
//            count = Convert.ToInt32(Console.ReadLine());
//            Vehicle[] myCar = new Vehicle[count];
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("Please input the information of the car:");
//                myCar[i] = GetCarInfo();
//            }

//            foreach (Vehicle key in myCar)
//            {
//                key.ShowCar();
//            }

//            Vehicle GetCarInfo()
//            {
//                Console.WriteLine("Please input the make of the car: ");
//                string input1 = Console.ReadLine();
//                while (input1 == " " || input1 == "")
//                {
//                    Console.WriteLine
//                    ("Please input the valid info of the car: ");
//                    input1 = Console.ReadLine();
//                }
//                string Make = input1;

//                Console.WriteLine("Please input the model of the car: ");
//                string input2 = Console.ReadLine();
//                while (input2 == " " || input2 == "")
//                {
//                    Console.WriteLine
//                    ("Please input the valid info of the car: ");
//                    input2 = Console.ReadLine();
//                }
//                string Model = input2;

//                Console.WriteLine("Please input the valid color of the car: ");
//                string input3 = Console.ReadLine();
//                while (input3 == " " || input3 == "")
//                {
//                    Console.WriteLine
//                    ("Please input the valid info of the car: ");
//                    input3 = Console.ReadLine();
//                }
//                string Color = input3;

//                Console.WriteLine("Please input the year of the car: ");
//                int num = -1;
//                do
//                {
//                    Console.WriteLine("Please input the valid year: ");
//                    Console.ReadLine();
//                }
//                while (!int.TryParse(Console.ReadLine(), out num));
//                int yearBuilt = Convert.ToInt32(Console.ReadLine());

//                Vehicle Car = new Vehicle(Make, Model, Color, yearBuilt);
//                return Car;
//            }
//        }
//    }
//}