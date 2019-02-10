using System;

namespace using_dispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WithDisposeMethod();
            WithUsingMethod(); 
        }

        private static void WithDisposeMethod()
        {
            Persona persona1 = new Persona(27);

            Console.WriteLine(persona1);
            if (persona1 is IDisposable) { persona1.Dispose(); }
        }

        private static void WithUsingMethod()
        {
            using(Persona persona2 = new Persona(37))
            {
                Console.WriteLine(persona2);
            }
        }
    }
}
