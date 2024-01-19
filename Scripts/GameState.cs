using Godot;
using System;
using System.Collections.Generic;

public partial class GameState : Node
{
    private Deck currentDeck;
    private static HashSet<int> gameUids = new HashSet<int>();

    internal Deck GetPlayerDeck()
    {
        return this.currentDeck;
    }

    internal bool IsNewGame()
    {
        return true;
    }

    public void AddDeckUID(int uid)
    {
        if (gameUids.Contains(uid)) 
        {
            throw new ArgumentException("DECK UID ALREADY EXISTS, WILL NOT OVERWRITE");
        }

        gameUids.Add(uid);
    }

    // Ensures all tracked IDs are unique
    public static int GetUid()
    {
        int i = (int)(GD.Randi() % 10000000);
        if (gameUids.Contains(i))
        {
            i = GetUid();
        }

        return i;
    }

    internal static void RemoveUidFromState(int uid)
    {
        gameUids.Remove(uid);
    }
}