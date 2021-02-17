using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facotry
{
    abstract class Pet
    {
        public abstract void SetName(string name);
        public abstract string Talk();
    }
}
