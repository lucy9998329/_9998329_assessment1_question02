using System;

namespace auto_ImplProperties
{
    //Creating a new class
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
        public string getColour(){return Colour;}
        public string getMake(){return Make;}
        public string getGearbox(){return Gearbox;}
        
            
        public string CarsDetail(){
            var carDetails = "Enter new car details bellow\n";            
            carDetails += $"Colour: {Colour}\n";
            carDetails += $"Make: {Make}\n";
            carDetails += $"Gearbox type: {Gearbox}\n";
            return carDetails;
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
            Console.WriteLine(car1.CarsDetail());
            Console.WriteLine($"This car is a " + car1.getColour() + " " + car1.getMake() + " with a " +  car1.getGearbox()  + " transmission. \n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
