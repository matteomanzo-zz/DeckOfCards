using System;
using System.Collections.Generic;

namespace DeckOfCards
{
	public class Deck
	{
		List<string> CardsDeck = new List<string>();

		public Deck ()
		{
			CreateDeck ();
		}

		private List<string> CreateDeck()
		{
			string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
			for (var x = 0; x <= 12; x++) {
				foreach (string elem in suits) {
					if (x == 0) {
						CardsDeck.Add ("Ace" + elem);
					} else if (x == 10) {
						CardsDeck.Add ("Jack" + elem);
					} else if (x == 11) {
						CardsDeck.Add ("Queen" + elem);
					} else if (x == 12) {
						CardsDeck.Add ("King" + elem);
					} else {
						CardsDeck.Add (x.ToString () + elem);
					}
				}
			}
			return CardsDeck;
		}

		public int Count
		{
			get {
				return CardsDeck.Count;
			}
		}

		public string DealCard()
		{
			string deal = CardsDeck [0];
			CardsDeck.RemoveAt (0);
			return deal;
		}
	}
}

