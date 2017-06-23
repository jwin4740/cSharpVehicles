using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWolfeVehicles
{
    public class AddVehicle
    {
  
        public List<object> autos = new List<object>();
        public void UserAddVehicle()
        {
            Vehicle novo = new Vehicle();
   

            
            Console.WriteLine("Please give me a vehicle type i.e. sedan, motorcycle, semi, truck");
            novo.Type = Console.ReadLine();
            Console.WriteLine("Please give me the color of your vehicle");
            novo.Color = Console.ReadLine();
            Console.WriteLine("Please give me the make of your vehicle");
            novo.Make = Console.ReadLine();
            Console.WriteLine("Please give me the mileage of your vehicle");
            novo.Mileage = int.Parse(Console.ReadLine());
            autos.Add(novo);
            AddMore();


        }
        public void GoToMovies()
        {
            if (autos.Count >= 1)
            {
                Console.WriteLine(autos[0]); // how do you do autos[0].Make
            }
          
        }
        public void ViewVehicles()
        {
            Console.WriteLine("\n");
            Console.WriteLine("HERE IS A LIST OF ALL YOUR VEHICLES: \n");
            autos.ForEach(Console.WriteLine);
            Console.WriteLine("\n Would you like to take a drive? (y or n)");

            char drive = Console.ReadKey().KeyChar;

            if (drive == 'y')
            {
                Console.WriteLine("\n");
                GoToMovies();
            }

        }
        public void AddMore()
        {
            Console.WriteLine("Would you like to add another vehicle? (y or n)");
            char response = Console.ReadKey().KeyChar;

            if (response == 'y')
            {
                Console.WriteLine("\n");
                
                UserAddVehicle();


            }
            else
            {

                ViewVehicles();
               

            }
        }
    }
}
