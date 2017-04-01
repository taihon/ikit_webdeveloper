using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Zoo
    {
        private List<Animal> _animals;
        public Manager mgr { get; set; }
        public Vet vet { get; set; }
        public List<Animal> Animals
        {
            get
            {
                if (_animals == null)
                    _animals = new List<Animal>();
                return _animals;
            }
            set
            {
                _animals = value;
            }
        }
    }
    public static class ZooExtMethods
    {
        public static int CountHorses(this Zoo zoo)
        {
            int counter = 0;
            foreach(var animal in zoo.Animals)
            {
                if (animal is Horse)
                    counter++;
            }
            return counter;
        }
    }
}
