using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interfaces_P2
{
    public abstract class Employee:IInventoryable, INotifyPropertyChanged
    {
        private string _name;
        public string Name { get { return _name; } set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Number { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string property="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public int CompareTo(object obj)
        {
            return Number - ((IInventoryable)obj).Number;
        }
    }
    public class Manager : Employee
    {

    }
    public class Boss:Employee
    {

    }
}
