using System;
namespace lab2
{
    public class Vehicle
    {
        public Vehicle()
        {
            x_ = 0;
            y_ = 0;
            price_ = 0;
            speed_ = 0;
            release_year_ = 0;
        }
        public Vehicle(double x, double y, double price, double speed, int release_year)
        {
            x_ = x;
            y_ = y;
            price_ = price;
            speed_ = speed;
            release_year_ = release_year;
        } 
        public double X
        {
            get => x_;
            set
            {
                x_ = value;
            }
        }
        public double Y
        {
            get => y_;
            set
            {
                y_ = value;
            }
        }
        public double price
        {
            get => price_;
            set
            {
                price_ = value;
            }
        }
        public double speed
        {
            get => speed_;
            set
            {
                speed_ = value;
            }
        }
        public int release_year
        {
            get => release_year_;
            set
            {
                release_year_ = value;
            }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Сoordinates: {X}, {Y}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Release year: {release_year}");
        }

        private double x_;
        private double y_;
        private double price_;
        private double speed_;
        private int release_year_;
    }

    public class Ship: Vehicle
    {
        private int passengers_;
        private string port_;
        public int passengers
        {
            get => passengers_;
            set
            {
                passengers_ = value;
            }
        }
        public string port
        {
            get => port_;
            set
            {
                port_ = value;
            }
        }
        public Ship(double x, double y, double price, double speed, int release_year, string port, int passengers): base(x, y, price, speed, release_year)
        {
            port_ = port;
            passengers_ = passengers;
        }
        public Ship()
        {
            passengers_ = 0;
            port_ = "";
        }
        public override void Print()
        {
            Console.WriteLine("Ship");
            base.Print();
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"Passengers: {passengers}");
        }

    }

    public class Car: Vehicle
    {
        private int passengers_;
        private string brand_;
        public int passengers
        {
            get => passengers_;
            set
            {
                passengers_ = value;
            }
        }
        public string brand
        {
            get => brand_;
            set
            {
                brand_ = value;
            }
        }
        public Car(double x, double y, double price, double speed, int release_year, string brand, int passengers) : base(x, y, price, speed, release_year)
        {
            brand_ = brand;
            passengers_ = passengers;
        }
        public Car()
        {
            passengers_ = 0;
            brand_ = "";
        }
        public override void Print()
        {
            Console.WriteLine("Car");
            base.Print();
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Passengers: {passengers}");
        }
    }

    public class Plane: Vehicle
    {
        private double height_ = 0;
        private int passengers_;
        public double height
        {
            get => height_;
            set
            {
                height_ = value;
            }
        }
        public int passengers
        {
            get => passengers_;
            set
            {
                passengers_ = value;
            }
        }
        public Plane(double x, double y, double price, double speed, int release_year, double height, int passengers) : base(x, y, price, speed, release_year)
        {
            height_ = height;
            passengers_ = passengers;
        }
        public Plane()
        {
            height_ = 0;
            passengers_ = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Plane");
            base.Print();
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Passengers: {passengers}");
        }
    }
}

