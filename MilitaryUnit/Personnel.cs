using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        public string name { get; set; }
        public int age { get; set; }
        public string role { get; set; }
        public string branch { get; set; }
        public Weapon weapon { get; set; }
        public Unit attachedTo { get; set; }

        public Personnel()
        {
            this.name = null;
            this.age = 0;
            this.role = null;
            this.branch = null;
            this.weapon = null;
            this.attachedTo = null;
        }

        public Personnel(string name, int age, string role, Weapon weapon, Unit attachedTo)
        {
            this.name = name;
            this.age = age;
            this.role = role;
            this.weapon = weapon;
            this.attachedTo = attachedTo;
        }
    }

    class Marine : Personnel
    {
        public Marine(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name,age,role,weapon,attachedTo)
        {
            this.branch = "USMC";
        }


    }

    class Soldier : Personnel
    {
        public Soldier(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name, age, role, weapon, attachedTo)
        {
            this.branch = "USA";
        }
    }

    class Sailor : Personnel
    {
        public Sailor(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name, age, role, weapon, attachedTo)
        {
            this.branch = "USN";
        }
    }

    class Airman : Personnel
    {
        public Airman(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name, age, role, weapon, attachedTo)
        {
            this.branch = "USMC";
        }
    }

    class Guardsman : Personnel
    {
        public Guardsman(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name, age, role, weapon, attachedTo)
        {
            this.branch = "USCG";

        }
    }

    class Spaceman : Personnel
    {
        public Spaceman(string name, int age, string role, Weapon weapon, Unit attachedTo) : base(name, age, role, weapon, attachedTo)
        {
            this.branch = "USSF";
        }
    }
}
