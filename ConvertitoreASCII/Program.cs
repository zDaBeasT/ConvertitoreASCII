using System;

namespace ConvertitoreASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il carattere da convertire: ");
            char input = Convert.ToChar(Console.ReadLine());
            int value = Convert.ToInt32(input);
            Console.WriteLine($"Il valore decimale di {input} è {value}");
            string hexOutput = String.Format("{0:X}", value);
            Console.WriteLine($"Il valore esadecimale di {input} è {hexOutput}");
            string binary = Convert.ToString(input, 2);
            Console.WriteLine($"Il valore binario di {input} è {binary}");
            Console.ReadLine();
        }
    }
}
