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
            Controller app = new Controller();
            app.StartApp();
			do 
			{
				app.RunApp ();
			} while (!app.Quit);
            app.CloseApp();
        }
    }
}
