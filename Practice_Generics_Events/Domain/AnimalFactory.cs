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
        public T Create(string name, Zoo zoo)
        {
            T animal = new T();
            animal.IAmHungry += zoo.mgr.OnHungry;
            animal.Name = name;
            zoo.vet.VaccinationDay += animal.OnVaccination;
            return animal;
        }
    }
}
