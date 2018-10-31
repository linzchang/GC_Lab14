using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class CountTestApp
    {
         
        public static void RunAlligator()
        {
            Alligator alligator = new Alligator("alligator");
            CountUtil.Count(alligator, 3);
        }

        public static void RunSheep()
        {
            Sheep sheep = new Sheep("Blackie");
            CountUtil.Count(sheep, 2);

            
            Console.WriteLine("Now, let us clone Blackie!");
            Sheep clone = sheep.Clone() as Sheep;
            string cloneName = Validation.GetName("\nVhat vould you like to name the clone? ");
            clone.Name = cloneName;
            clone.ResetCount();
            int userNumber = Validation.GetNumber($"\nHow many times vould you like to count {cloneName}? ");
            CountUtil.Count(clone, userNumber);
            sheep.ResetCount();

            CountUtil.Count(sheep, 1);
        }
    }
}
