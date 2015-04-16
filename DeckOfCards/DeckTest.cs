using NUnit.Framework;
using System;

namespace DeckOfCards
{
	[TestFixture ()]
	public class DeckTest
	{
		Deck deck;

		[SetUp()]
		public void Init()
		{
			deck = new Deck ();
		}

		private bool DeckContainsCard(string card)
		{
			for (var x = 0; x <= deck.Count; x++) {
				if (card == deck.DealCard()) {
					return true;
				}
			};
			return false;
		}

		[Test ()]
		public void DeckShouldContainTheAceHeartsCard ()
		{
			Assert.IsTrue (DeckContainsCard ("AceHearts"));
		}

		[Test ()]
		public void DeckShouldContain52Cards ()
		{
			Assert.AreEqual (52, deck.Count);
		}

		[Test ()]
		public void DeckShouldContainFourSuits ()
		{
			var DeckContainsFourSuits = false;
			DeckContainsFourSuits = DeckContainsCard ("AceHearts") && DeckContainsCard ("AceDiamonds") && DeckContainsCard ("AceSpades") && DeckContainsCard ("AceClubs");
			Assert.IsTrue (DeckContainsFourSuits);
		}

		[Test ()]
		public void DeckShouldDealTheTopCard ()
		{
			Assert.AreEqual (deck.DealCard(), "AceHearts");
		}

		[Test ()]
		public void DeckShouldRemoveTheCardWhenDeal ()
		{
			deck.DealCard ();
			Assert.AreEqual (51, deck.Count);
		}

		[Test ()]
		public void DeckShouldNotHaveDuplicates ()
		{
			deck.DealCard ();
			Assert.IsFalse (DeckContainsCard ("AceHearts"));
		}

	}
}

