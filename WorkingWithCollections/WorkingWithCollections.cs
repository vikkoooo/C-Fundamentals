﻿namespace WorkingWithCollections
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0=000=00000=0";
            */

			/*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
                
            }
            */

			/*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make); 
            }
            */

			/*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

			//string[] names = { "Bob", "Steve", "Brian", "Chuck" };

			Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
			Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

			List<Car> myList = new List<Car>
			{
				new Car {Make = "Oldsmobile", Model = "Cutless Supreme", VIN = "A1" },
				new Car {Make = "Nisan" , Model = "Altima", VIN = "F6" }
			};
		}

		class Car
		{
			public string Make { get; set; }
			public string Model { get; set; }
			public string VIN { get; set; }
		}

		class Book
		{
			public string Title { get; set; }
			public string Author { get; set; }
			public string ISBN { get; set; }
		}
	}
}