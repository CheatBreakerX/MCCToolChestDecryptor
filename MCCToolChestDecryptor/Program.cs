// See https://aka.ms/new-console-template for more information
using System;
using System.Windows.Forms;

namespace MCCToolChestDecryptor {
	class Program {
		[STAThread]
		public static void Main(string[] args) {
			Console.WriteLine("Welcome to the MCCToolChest string decryptor!");

			bool shouldCopyToClipboard = true;
			Console.Write("Should I copy the result to your clipboard automatically? (Y/n) > ");
			string inp = Console.ReadLine();
			if (inp != null && inp.Length > 0) {
				shouldCopyToClipboard = inp.ToLower().Equals("y") || inp.ToLower().Equals("yes");
			}

			string val = null;
			while (val == null || val.Length != 0) {
				Console.Write("> ");
				val = Console.ReadLine();
				if (val != null && val.Length > 0) {
					if (val.Equals("raw") || val.Equals("raw-s")) {
						if (Class50.byte_3 == null || Class50.byte_3.Length == 0) { // oh no its null
							Class50.GetObfuscatedString(0); // oh yeah its not null
						}

						Console.WriteLine($"========== START RAW DATA ({Class50.byte_3.Length}) ==========");
						for (int i = 0; i < Class50.byte_3.Length; i++) {
							int asInt = (int)(Class50.byte_3[i]);
							if (val.Equals("raw-s")) {
								Console.Write((char)asInt);
							}
							else {
								string asHex = asInt.ToString("x");
								if (asHex.Length < 2) {
									asHex = $"0{asHex}";
								}
								Console.Write($"\\x{asHex}");
							}
						}
						Console.WriteLine("");
						Console.WriteLine($"=========== END RAW DATA ({Class50.byte_3.Length}) ===========");
					}
					else if (val.Equals("all")) {
						if (Class50.byte_3 == null || Class50.byte_3.Length == 0) { // oh no its null
							Class50.GetObfuscatedString(0); // oh yeah its not null
						}

						int cur = 0;
						int stringCount = 0;
						while (cur + 4 < Class50.byte_3.Length) {
							string real = Class50.GetObfuscatedString(cur);
							Console.WriteLine($"{cur}: {real}");
							cur += 4;				// account for string size (as int, 4 bytes)
							cur += real.Length * 2;	// account for unicode (*2 bytes)
							stringCount++;
						}
						Console.WriteLine($"Total string count: {stringCount}");
					}
					else {
						string newString = Class50.GetObfuscatedString(Convert.ToInt32(val));
						Console.WriteLine(newString);
						if (shouldCopyToClipboard) {
							Clipboard.SetText(newString);
						}
					}
				}
			}
		}
	}
}
