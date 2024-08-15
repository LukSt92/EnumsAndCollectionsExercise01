using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise01
{
    class Card
    {
        public Card(string value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public string Value { get; private set; }
        public string Suit { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }
    }
}
