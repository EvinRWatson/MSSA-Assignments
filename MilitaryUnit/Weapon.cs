using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        public string name { get; set; }

        public Weapon()
        {
            this.name = "Hands";
        }
    }

    class M4 : Weapon
    {
        public M4()
        {
            this.name = "M4";
        }
    }
}
