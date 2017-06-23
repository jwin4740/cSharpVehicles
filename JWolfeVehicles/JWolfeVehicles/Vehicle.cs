using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWolfeVehicles
{
    public class Vehicle
    {
    
        public string Make;
        public string Type;
        public string Color;
        public int Mileage;
        public Vehicle()               // why do you need this??
        {
            this.Make = "Ford";
            this.Type = "Sedan";
            this.Color = "Black";
            this.Mileage = 0;
        }

        //public Vehicle(string make, string type, string color, int mileage)
        //{
        //    this.Make = make;
        //    this.Type = type;
        //    this.Color = color;
        //    this.Mileage = mileage;

        //}

        public override string ToString()
        {
            return string.Format("Make: {0}  Type: {1}  Color: {2}  Mileage: {3}", Make, Type, Color, Mileage);
        }

    }


}
