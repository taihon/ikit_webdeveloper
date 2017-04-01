using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var vet = new Vet();
            var mgr = new Manager();
            var zoo = new Zoo { mgr = mgr, vet = vet };
            AnimalFactory<Horse> factory = new AnimalFactory<Horse>();
            var horse = factory.Create("Milly", zoo);
            horse.Hungry();
            vet.BeginVaccination();
        }
    }
}
