using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskForGame.ViewModels
{
    using Services;
    using SharedModels;

    public class DeskForGameViewModel
    {
        private readonly IHands allHands;
        private readonly CardsRandomDealService cardsRandomDeal = new CardsRandomDealService();
        public DeskForGameViewModel(IHands allHands)
        {
                        this.allHands = allHands;
        }
        public string CardFace => @"..\Images\" + allHands.South.SetCards[1].CardFaceFileName;


      }
}
