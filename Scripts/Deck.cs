using Godot;
using System;
using System.Collections.Generic;

public partial class Deck : Object, IComparable<Deck>
{
    private int uid;
    private List<card_base> cards = new List<card_base>();


    public Deck(int uid, List<card_base> cards = null)
    {
        this.uid = uid;
        if (cards != null)
        {
            this.cards = cards;
        }
    }

    public int CompareTo(Deck other)
    {
        if (other == null) throw new ArgumentNullException("other");

        if (object.ReferenceEquals(this, other) || this.uid == other.uid) return 1;

        return 0;
    }

    public int Shuffle()
    { 
        for (int c = 0; c < cards.Count; c++)
        {

        }
        return cards.Count; 
    }
}