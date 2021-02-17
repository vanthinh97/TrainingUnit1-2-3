using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facotry
{
    class PeopleHaveCat : People
    {
        public override void SetPet()
        {
            myPet = new Cat("Meo Meo Meo");
        }
    }
}
