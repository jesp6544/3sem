using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace JSON_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.hk = 10;
            car.bla = 1000;
            car.text = "asdflkasdfdsfg";

            Car[] carAr = new Car[2];
            carAr[0] = car;
            carAr[1] = new Car(){ hk = 20, bla = 2, text = "nr2"};
            
                string test = JsonConvert.SerializeObject(carAr, Formatting.Indented);
            dynamic testing = JsonConvert.DeserializeObject(test);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"config.JSON",test);
            //Console.WriteLine(testing.hk);
            Console.ReadLine();
        }
    }

    class Car
    {
        public int hk { get; set; }
        public int bla { get; set; }
        public string text { get; set; }
    }
}
