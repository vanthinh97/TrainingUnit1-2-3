using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facotry
{
    class PeopleHaveDog : People
    {
        public override void SetPet()
        {
            myPet = new Dog("Gau Gau Gau");
        }
    }
}
