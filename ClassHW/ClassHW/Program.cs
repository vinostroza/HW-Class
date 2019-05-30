using System;

namespace ClassHW
{

    class Program
    {
        static void Main(string[] args)
        {

            Car auto = new Car("Buick", 2015, true);
            auto.carDoes("moving");
            Car auto2 = new Car("Buick", 2015, true);
            auto2.carDoes2(34);


            //Car auto = new Car(string auto);

            //auto.Brand = "Buick";
            //auto.Model = "Regal";
            //auto.Year = 2015;
            //auto.hasMoonRoof = true;

            //auto.Description();


        }

        public class Car
        {
 
        //properties
        public string _brand { set; get; }
        public int _year { set; get; }
        public bool _MoonRoof {set;get;}

        //the constructor

        public Car(string brand, int year, bool MoonRoof)
        {
            _brand = brand;
            _year = year;
            _MoonRoof = MoonRoof;
            Console.WriteLine("Your dream car is out for sale!");
            Console.WriteLine("The car brand is {0}", brand);
            Console.WriteLine("The car's year is: {0}", year);
            Console.WriteLine("The car features moonroof:{0}", MoonRoof);
        }
        
        public void carDoes(String moves)
            {
                Console.WriteLine("The car is {0}", moves);
            }

            public void carDoes2(int mileage)
            {
                Console.WriteLine("The car gives {0} miles per hour", mileage);
            }
        }
        
    }

}
