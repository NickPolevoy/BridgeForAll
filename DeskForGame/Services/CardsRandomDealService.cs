namespace DeskForGame.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Prism.Mvvm;
    using SharedModels;

    public class CardsRandomDealService :  ICardsRandomDealService
    {
        
        public Hands GetCardsRandomDeal()
        {
            var deck = new Deck();

            var shuffledDeck = Shuffle(deck.GenerateDeck());
            var hands = new Hands {South = {Points = 0}, West = {Points = 0}, North = {Points = 0}, East = {Points = 0}};

            int j = 0;
            for (int i = 0; i < 13; i++)
            {
                hands.South.Points += shuffledDeck[j].Point;
                hands.South.SetCards.Add(shuffledDeck[j++]);

                hands.West.Points += shuffledDeck[j].Point;
                hands.West.SetCards.Add(shuffledDeck[j++]); 

                hands.North.Points += shuffledDeck[j].Point;
                hands.North.SetCards.Add(shuffledDeck[j++]); 

                hands.East.Points += shuffledDeck[j].Point;
                hands.East.SetCards.Add(shuffledDeck[j++]); ;
            }

            var result = hands.South.SetCards.OrderBy(s => s.Suit).ThenBy(s => s.FaceValue).ToList();
            hands.South.SetCards.Clear();
            foreach (var card in result) {
                hands.South.SetCards.Add(card);
            }
            return hands;
        }

 
        List<Card> Shuffle(List<Card> startDeck)
        {
            var random = new Random();
            for (int i = 0; i < 52; i++)
            {
                var r = random.Next(52);
                SwapCard(startDeck, i, r);
            }
            return startDeck;
        }

        private void SwapCard(IList<Card> cards, int index1, int index2)
        {
            var card = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = card;
        }
 
    }
}
