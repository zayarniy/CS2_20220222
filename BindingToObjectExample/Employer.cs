using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObjectExample
{
    public class Employer : INotifyPropertyChanged
    {
        private string name = "None";
        private string description = "None";
        private int age = 20;

        public string Name { get => name; 
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public string Description { get => description; set => description = value; }
        public int Age { get => age; set => age = value; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
