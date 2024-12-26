using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndUsingObjects
{
    public class Cat
    {
        // Field Name
        public string Name { get; set; }
        // Field color
        private string color;

        // Parameterless contructor
        public Cat()
        {
            this.Name = "Unnamed";
            this.color = "gray";
        }

        public Cat(string name, string color)
        {
            this.Name = name;
            this.color = color;
        }

        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", Name);
        }
    }
}
