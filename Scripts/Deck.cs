using Godot;
using System;
using System.Collections.Generic;

public partial class Deck : Object, IComparable<Deck>
{
    private int uid;
    private List<card_base> cards = new List<card_base>();
    private static GameState gameState;

    public Deck(int uid, List<card_base> cards = null)
    {
        this.uid = uid;
        if (cards != null)
        {
            this.cards = cards;
        }

        gameState.AddDeckUID(uid);
    }

    public static List<card_base> NewGameDeckList = new List<card_base>() {
        CardData.CloneCard(1),
        CardData.CloneCard(3),
        CardData.CloneCard(3),
        CardData.CloneCard(5),
        };

    public static Deck NewGameDeck()
    {
        return new Deck(GameState.GetUid(), NewGameDeckList);
    }

    public int CompareTo(Deck other)
    {
        if (other == null) throw new ArgumentNullException("other");

        if (object.ReferenceEquals(this, other) || this.uid == other.uid) return 1;

        return 0;
    }

    public void RemoveCard(int cardUid)
    {
        foreach (var card in cards) 
        { 
            if (card.uid == cardUid) 
                cards.Remove(card); 
        }
    }

    public int Shuffle()
    { 
        Random rnd = new Random();
        Deck unshuffled = new Deck(0, this.cards);
        this.cards = new List<card_base>();
        for (int c = 0; c < cards.Count; c++)
        {
            int ndx = rnd.Next(0, cards.Count);
            this.cards.Add(unshuffled.cards[ndx]);
            unshuffled.RemoveCard(unshuffled.cards[ndx].uid);
        }

        return cards.Count; 
    }
}