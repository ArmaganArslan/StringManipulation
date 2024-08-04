using System;

namespace StringManipulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Bir string ve bir indeks girin (örneğin: 'Algoritma,3'): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Girdi boş olamaz.");
                    continue;
                }

                var parts = input.Split(',');

                if (parts.Length != 2)
                {
                    Console.WriteLine("Geçerli bir format girin: string,indeks");
                    continue;
                }

                string text = parts[0];
                if (!int.TryParse(parts[1], out int index) || index < 0 || index >= text.Length)
                {
                    Console.WriteLine("Geçerli bir indeks girin.");
                    continue;
                }

                string result = RemoveCharacterAt(text, index);

                Console.WriteLine(result);
            }
        }

        private static string RemoveCharacterAt(string text, int index)
        {
            if (index < 0 || index >= text.Length)
                return text;

            return text.Remove(index, 1);
        }
    }
}
