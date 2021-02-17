using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facotry
{
    class Cat : Pet
    {
        private string name;
        public override void SetName(string name)
        {
            this.name = name;
        }

        public override string Talk()
        {
            return name;
        }

        public Cat(string name)
        {
            this.name = name;
        }
    }
}
