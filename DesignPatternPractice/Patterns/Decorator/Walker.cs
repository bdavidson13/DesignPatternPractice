using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Patterns.Decorator
{
    public class Walker : IComponent
    {
        public string Name
        {
            get
            {
                return Component.Name;
            }
        }
        private IComponent Component;

        public Walker(IComponent component)
        {
            this.Component = component;
        }
        public string Action()
        {
            return Component.Action();
        }

        public string Walk()
        {
            return $"{Name} is walking";
        }
    }
}
