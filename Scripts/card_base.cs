using Godot;
using System;
using static CardData;

public partial class card_base : MarginContainer
{
	string DefaultCardInfo = "UNINITIALIZED CARD INFO";
	string CardInfo;
	string CardFlavorText;
	Image CardImage = null;
	private string name;
	private CardType type;
	private int cost;
	private int blood;
	private int attack;

	private int borderWidth = 5;

	public card_base(string name, CardType type, int cost, int blood, int attack, string cardInfo, string flavorText = "")
	{
		this.name = name;
		this.type = type;
		this.cost = cost;
		this.blood = blood;
		this.attack = attack;
		this.CardInfo = cardInfo == null ? cardInfo : DefaultCardInfo;
		this.CardFlavorText = flavorText;
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Created a card named " + this.name + "!");

		switch (type)
		{
			case CardType.Action:
				break;
			case CardType.Creature:
				break;
			case CardType.Enhancement:
				break;
			case CardType.Environment:
				break;
			default:
				break;

		}



		AddThemeConstantOverride("margin_top", borderWidth);
		AddThemeConstantOverride("margin_left", borderWidth);
		AddThemeConstantOverride("margin_bottom", borderWidth);
		AddThemeConstantOverride("margin_right", borderWidth);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
