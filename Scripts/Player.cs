using Godot;
using System;

public partial class Player : Node2D
{
    Deck deck;
    GameState gameState;

    public override void _Ready()
    {
        GameState gameState = GetNode("GameState") as GameState;
        LoadDeck();
    }

    // When we have other decks you can load, this will return TRUE if it's successful and FALSE when the currentDeck fails to load.
    public bool LoadDeck(Deck deck = null)
    {
        if (deck == null)
        {
            if (gameState.IsNewGame())
            {
                // Load New Game Deck
                deck = Deck.NewGameDeck();
            }

            else
            {
                deck = gameState.GetPlayerDeck());
            }

        }

        return true;
    }
}
