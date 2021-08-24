using System;

namespace Hospital_Service_System
{
	public class Program : Dasar //inheritance
	{
		public static void Main()
		{
			start();
			int pilih;

			Welcoming who = new Welcoming();
			who.person = "pasien";
			who.Welcome();
			menu();
			
			switch (Convert.ToInt32(Console.ReadLine())) // conditional & looping
			{
				case 1:
					for (i = 0; i < dokter.Length; i++)
					{
						pemeriksaan();
					}

					pemeriksaan1();
					switch (int.Parse(Console.ReadLine()))
					{
						case 1:
							pemeriksaan2();
							//	a = Console.ReadLine();
							if (int.Parse(Console.ReadLine()) == 1)
							{
								pemeriksaan4(hargaumum);
							}
							else
							{
								pemeriksaan3(hargaumum);
							}

							break;
						case 2:
							pemeriksaan2();
							string b = Console.ReadLine();
							if (b == "ya")
							{
								pemeriksaan4(hargaanak);
							}
							else
							{
								pemeriksaan3(hargaanak);
							}

							break;
					}

					break;
				case 2:
					pembelian();
					switch (int.Parse(Console.ReadLine()))
					{
						case 1:
							pembelian1();
							string c = Console.ReadLine();
							if (c == "1")
							{
								quantity();
								quan = Convert.ToInt32(Console.ReadLine());
								totalbayar(hargaobat1, quan);
							}
							else if (c == "2")
							{
								quantity();
								quan = Convert.ToInt32(Console.ReadLine());
								totalbayar(hargaobat2, quan);
							}

							break;
						case 2:
							pembelian2();
							break;
					}

					break;
			}

			Additional byee = new Dasar();
			byee.bye();
		}

		public static void start()
		{
			Console.WriteLine("-------------------------RS. INDONESIA HOSPITAL------------------------");
			Console.WriteLine(" ");
			Console.WriteLine("SELAMAT DATANG DI RUMAH SAKIT KAMI");
		}

		public static void menu()
		{
			Console.WriteLine("1. Pemeriksaan Kesehatan");
			Console.WriteLine("2. Pembelian Obat");
			Console.WriteLine("Silahkan pilih layanan! (masukan nomor ekstensi yang dituju)");
		}

		public static void pemeriksaan()
		{
			Console.WriteLine(dokter[i] + " (" + keahlian[i] + ") " + " - " + jampraktik[i]);
		}

		public static void pemeriksaan1()
		{
			Console.WriteLine("Silahkan pilih pemeriksaan yang dituju untuk mendaftar. Cukup tuliskan nomor urut dokter dibawah.");
		}

		public static void pemeriksaan2()
		{
			Console.WriteLine("Apakah Anda akan menggunakan BPJS Kesehatan? (Jawab dengan '1' untuk'ya' atau '2' untuk'tidak')");
		}

		public static void pemeriksaan3(int a)
		{
			Console.WriteLine("Terima Kasih. Pendaftaran Anda sudah teregistrasi. Silahkan membayar biaya pendaftaran di kasir sejumlah Rp " + a);
		}

		public static void pemeriksaan4(int a)
		{
			Console.WriteLine("Terima Kasih. Pendaftaran Anda sudah teregistrasi. Silahkan membayar biaya pendaftaran di kasir sejumlah Rp" + (a - (a * 20 / 100))); //operator aritmatika
		}

		public static void pembelian()
		{
			Console.WriteLine("1. Tanpa resep");
			Console.WriteLine("2. Dengan resep");
			Console.WriteLine("Silahkan pilih (tuliskan angka)");
		}

		public static void pembelian1()
		{
			Console.WriteLine("1. Paracetamol");
			Console.WriteLine("2. OBH Combi");
			Console.WriteLine("Silahkan pilih (tuliskan angka)");
		}

		public static void pembelian2()
		{
			Console.WriteLine("Untuk pembelian obat dengan resep silahkan menuju meja pelayanan no. 2. Terima kasih.");
		}

		public static void quantity()
		{
			Console.WriteLine("Berapa banyak? (tuliskan angka)");
		}

		public static void totalbayar(int harga, int quan)
		{
			Console.WriteLine("Total belanja obat Anda : ");
			Console.WriteLine(harga + "*" + quan);
			Console.WriteLine(harga * quan);
		}
	}
}
