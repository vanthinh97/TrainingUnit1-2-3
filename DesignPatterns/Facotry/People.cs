using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facotry
{
    abstract class People
    {
        protected Pet myPet;

        public abstract void SetPet();
        public void PetInfo()
        {
            Console.WriteLine("Mypet talks: " + myPet.Talk());
        }
    }
}
