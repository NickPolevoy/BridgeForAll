using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Deck
    {
        public List<Card> GenerateDeck()
        {
            var temp = Enum.GetValues(typeof(Suit)).Cast<Suit>()
                .SelectMany(suit => Enum.GetValues(typeof(FaceValue)).Cast<FaceValue>(),
                    (suit, faceVal) => new Card(suit, faceVal, true)).ToList();

            foreach (var t in temp)
            {
                t.CardFaceFileName = t.GetImageFileName(t);
            }
            return temp;
        }

    }
}
