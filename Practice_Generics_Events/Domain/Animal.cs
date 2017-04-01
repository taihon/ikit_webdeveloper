using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Animal
    {
        public string Name { get; set; }
    }
    public class Horse : Animal, IZooAnimal
    {
        public Horse() { }
        public Horse(string name)
        {
            Name = name;
        }
    }
    public interface IZooAnimal
    {

    }
}
