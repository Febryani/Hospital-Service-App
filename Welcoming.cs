using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Service_System
{
	public class Welcoming
	{
		private string nama; //encapsulation
		public string person;
		public void Welcome() //constructor
		{
			Console.WriteLine("Ketikan nama Anda dibawah ini");
			nama = Console.ReadLine();
			Console.WriteLine("Halo " + person + " " + nama + " ! Silahkan pilih menu dibawah ini. Cukup tuliskan nomernya saja.");
		}
	}
}
