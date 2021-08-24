using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Service_System
{
	public class Dasar : Additional
	{
		public static string[] dokter = { "1. Dr Lusiana Anggraeni", "2. Dr Yasmar Alfa Sp.AK" };
		public static string[] keahlian = { "Dokter Umum - Rp.100.000", "Dokter Anak - Rp. 180.000" };
		public static string[] jampraktik = { "08.00 WIB - 12.00 WIB", "13.30 WIB - 16.00 WIB" };
		public static int hargaumum = 100000;
		public static int hargaanak = 180000;
		public static int hargaobat1 = 18000;
		public static int hargaobat2 = 10000;
		public static int quan;
		public static int i;
		public override void bye() //override
		{
			Console.WriteLine("Terima Kasih atas kunjungan Anda. Semoga sehat selalu.");
		}
	}
}
