using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Sheep : ICountable, ICloneable
    {
        public static int SheepCount;
        public string Name { get; set; }

        public Sheep(string name)
        {
            Name = name;
        }

        public void IncrementCount()
        {
            SheepCount++;
        }

        public void ResetCount()
        {
            SheepCount = 0;
        }

        public int GetCount()
        {
            return SheepCount;
        }

        public string GetCountString()
        {
            //if ((SheepCount % 3) == 0)
            //{
            //    return $"{SheepCount.ToString()} {Name} {CountChuckle.AhAhAh()}";
            //}
            return $"{SheepCount.ToString()} {Name}";
        }

        public object Clone()
        {
            return new Sheep(Name);
        }
    }
}
