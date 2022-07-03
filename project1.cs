using System;

namespace ConsoleApp3
{
    class Project1
    {
        static void Main(string[] args)
        {
            CarParkingCalculator bike = new CarParkingCalculator();
            bike.vehicleType = "Bike";
            bike.threeHrRent = 2;
            bike.oneHrRent = 0.5;
            bike.twentyFourHrRent = 10;
            CarParkingCalculator car = new CarParkingCalculator();
            car.vehicleType = "Car";
            car.threeHrRent = 4;
            car.oneHrRent = 1;
            car.twentyFourHrRent = 20;
            CarParkingCalculator bus = new CarParkingCalculator();
            bus.vehicleType = "Bus";
            bus.threeHrRent = 6;
            bus.oneHrRent = 1.5;
            bus.twentyFourHrRent = 30;
            //you want to know the rent for 3 vehicles
            int n=0;
            while (n<4)
            {
                Console.WriteLine("Enter Vehicle Type:");
                string vehicle = Console.ReadLine();
                Console.WriteLine("Number of hours");
                string num = Console.ReadLine();
                int numOfHrs = Convert.ToInt32(num);
                if (vehicle == bike.vehicleType)
                {
                    bike.CalculateRent(numOfHrs);
                }
                if (vehicle == car.vehicleType)
                {
                    car.CalculateRent(numOfHrs);
                }
                if (vehicle == bus.vehicleType)
                {
                    bus.CalculateRent(numOfHrs);
                }
                n = n + 1;
            }


        }
        class CarParkingCalculator
        {   public string vehicleType;
            public int threeHrRent;
            public double oneHrRent;
            public int twentyFourHrRent;
            public void CalculateRent(int numberOfHrs)
            {
                Console.WriteLine("Rent for"+" " +vehicleType+" " + "in dollar=");
               if (numberOfHrs == 3)
                {
                    Console.WriteLine(threeHrRent);
                }
                if (numberOfHrs > 3 & numberOfHrs < 24)
                {
                    Console.WriteLine(threeHrRent + (numberOfHrs-3)*oneHrRent);
                }
                if (numberOfHrs == 24)
                {
                    Console.WriteLine(twentyFourHrRent);
                }
            }
        }
    }
}
