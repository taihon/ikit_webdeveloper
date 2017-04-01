using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AnimalFactory<T> 
        where T : Animal, IZooAnimal, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
