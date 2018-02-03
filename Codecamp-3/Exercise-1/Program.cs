using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1
{
    class City
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public City (string city)
        {
            this.Name = city;
            this.Length = city.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities =  
            {
                "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"
            };

            List<City> cityList = new List<City>();

            foreach (var city in cities)
            {
                cityList.Add( new City(city) );
            }

            var orderResult = from city in cityList
                                orderby city.Length, city.Name
                                select city.Name;
            List<string> newList = orderResult.ToList();
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
