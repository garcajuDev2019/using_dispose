using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_dispose
{
    internal class Persona : IDisposable
    {
        private int age;

        public Persona(int edad)
        {
            this.age = edad;
        }

        public override string ToString() => string.Format($"La edad de esta persona es de {age} años");

        public void Dispose() => Console.WriteLine("Se ha llamado a .Dispose(), aquí se libera el recurso no administrado");
    }
}
