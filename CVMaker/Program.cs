using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVMaker
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new insertform());
			//Application.Run(new CV());
			Application.Run(new splashscreen());
			//Application.Run(new adminForm2());
			//Application.Run(new Formregister());
		}
	}
}
