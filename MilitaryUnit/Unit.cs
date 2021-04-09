using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    
    class Unit
    {
        public string name { get; set; }
        public int size { get; set; }
        public string mission { get; set; }
        public int numPersonnel { get; set; }
        public string branch { get; set; }
        public Unit attachedTo { get; set; }

        public Unit()
        {
            this.name = "Unnamed";
            this.mission = "General Support";
            this.numPersonnel = 0;
            this.branch = "None";
        }
        public Unit(string name, int size, string mission, string branch)
        {
            this.name = name;
            this.size = size;
            this.mission = mission;
            this.branch = branch;
        }

        public string Print()
        {
            return $"Size: {size}\nBranch: {branch}\tMission: {mission}\n";
        }
    }

    class Platoon : Unit
    {
        public Platoon(string name, int size, string mission, string branch) : base (name, size, mission, branch)
        {
        }
    }

    class Squad : Platoon
    {
        public Squad(string name, int size, string mission, string branch) : base(name, size, mission, branch)
        {
        }
    }

    class Team : Squad
    {
        public Team(string name, int size, string mission, string branch) : base(name, size, mission, branch)
        {
        }
    }
}
