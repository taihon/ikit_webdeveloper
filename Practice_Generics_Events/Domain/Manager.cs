using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Manager
    {
        public void OnHungry(Animal animal, HungryEventArgs args)
        {
            var foodType = args.IsMeatEater ? "Meat" : "Silo";
            Console.WriteLine($"Fine. We'll bring {args.FoodAmount} of {foodType}");
        }
    }
    public class Vet
    {
        public event EventHandler VaccinationDay;
        public void BeginVaccination()
        {
            VaccinationDay?.Invoke(this, EventArgs.Empty);
        }
    }
}
