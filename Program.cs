using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütlen sırasıyla bir string ve bir sayı girin(aralarında virgül ile)");
            string input = Console.ReadLine();
            String[] parts =input.Split(',');
            if (int.TryParse(parts[parts.Length-1], out int index)){

                string valueToRemove =','+ Convert.ToString(index);
                string text1=input.Replace(valueToRemove,"");
            

            if (index >= 0 && index < text1.Length)
            {
                // Belirtilen indexten karakteri çıkartarak yeni string oluştur
                string result = text1.Remove(index, 1);
                Console.WriteLine($"Sonuç: {result}");
            }
            else
            {
                Console.WriteLine("Geçersiz index.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz girdi. Lütfen string ve sayı arasında virgül kullanarak tekrar deneyin.");
        }

        }
    }
}