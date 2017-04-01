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
        public virtual void Hungry() { }
    }
    public delegate void HungryHandler(Animal sender, HungryEventArgs args);
    public class HungryEventArgs : EventArgs
    {
        public bool IsMeatEater { get; set; }
        public int FoodAmount { get; set; }
    }
    public class Horse : Animal, IZooAnimal
    {
        public Horse() { }
        public Horse(string name)
        {
            Name = name;
        }

        public event HungryHandler IAmHungry;

        public override void Hungry()
        {
                IAmHungry?
                    .Invoke(this, 
                        new HungryEventArgs
                        {
                            FoodAmount =10,
                            IsMeatEater = false
                        });
        }
    }
    public interface IZooAnimal
    {
        event HungryHandler IAmHungry;
    }
}
