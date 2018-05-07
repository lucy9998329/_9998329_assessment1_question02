using System;

namespace auto_ImplProperties
{
    //Creating a new class named Car
    class Cars
    {
        //Auto-implemented properties for get and set
        public string Colour {get; set; }
        public string Make {get; set; }
        public string Gearbox {get; set; }

        //Constructor
        public Cars(string colour, string make, string gearbox)
        {
            Colour = colour;
            Make = make;
            Gearbox = gearbox;
        }
        //Methods
        public string DisplayCars(){
            var carDetails = "Enter new car details bellow\n";            
            carDetails += $"Colour: {Colour}\n";
            carDetails += $"Make: {Make}\n";
            carDetails += $"Gearbox type: {Gearbox}\n";
            return carDetails;
        } 
        //Overriding the method in the Car class
        public override string ToString(){
            return $"This car is a "+ Colour + " " + Make + " with a " +  Gearbox  + " transmission. ";
        }            
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            //Initializing a new object
            Cars car1 = new Cars ("green", "Ford", "manual");     
            Console.WriteLine(car1.DisplayCars());
            Console.WriteLine(car1.ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
