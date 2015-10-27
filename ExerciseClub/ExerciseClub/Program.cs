using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClub
{
    class Program
    {
        static void Main(string[] args)
		{
			Menu mainMenu = new Menu();

			do 
			{
				mainMenu.RunMenu ();
			} while (Console.ReadLine () != "q");
        }
    }
}
