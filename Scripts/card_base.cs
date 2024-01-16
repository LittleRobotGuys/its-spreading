using Godot;
using System;

public partial class card_base : MarginContainer
{
	string DefaultCardInfo = "UNINITIALIZED CARD INFO";
    string CardInfo;
	Image CardImage = null;
    private string name;
    private int cost;
    private int blood;
    private int attack;

    public card_base(string name, int v2, int v3, int v4, string cardInfo)
    {
        this.name = name;
        this.cost = v2;
        this.blood = v3;
        this.attack = v4;
        this.CardInfo = cardInfo == null? cardInfo : DefaultCardInfo;
    }


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
