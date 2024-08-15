using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise01
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            Card myCard = new Card((Values)random.Next(1,14), (Suits)random.Next(4));
            Console.WriteLine(myCard.Name);
        }
    }
}
