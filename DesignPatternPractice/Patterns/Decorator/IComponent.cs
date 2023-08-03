﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Patterns.Decorator
{
    public interface IComponent
    {
        string Name { get; }
        string Action();
    }
}
