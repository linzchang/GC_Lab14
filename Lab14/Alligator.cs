using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Alligator : ICountable
    {
        public static int AlligatorCount;
        public string Name;

        public Alligator(string name)
        {
            Name = name;
        }

        public void IncrementCount()
        {
            AlligatorCount++;
        }

        public void ResetCount()
        {
            AlligatorCount = 0;
        }

        public int GetCount()
        {
            return AlligatorCount;
        }

        public string GetCountString()
        {
            ////if ((AlligatorCount % 3) == 0)
            ////{
            ////    return $"{AlligatorCount.ToString()} {Name} {CountChuckle.AhAhAh()}";
            ////}
            return $"{AlligatorCount.ToString()} {Name}";
        }
    }
    
}
