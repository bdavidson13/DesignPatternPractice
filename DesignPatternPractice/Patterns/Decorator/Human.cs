using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Patterns.Decorator
{
    public class Human : IComponent
    {
        public string Name { get; protected set; }

        public Human (string name)
        {
            Name = name;
        }

        public string Action()
        {
            return $"This is a Human named {Name}";
        }
    }
}
