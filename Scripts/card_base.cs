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
	private int initial_blood_value;
	private int blood_modifier;
	private int attack;
	private Label BloodLabel, AttackLabel, CostLabel;
	private Deck cardDeck;

	private int borderWidth = 5;

	public card_base(string name, CardType type, int cost, int blood, int attack, string cardInfo, string flavorText = "")
	{
		this.name = name;
		this.type = type;
		this.cost = cost;
		this.initial_blood_value = blood;
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

        BloodLabel = GetNode<Label>("BloodLabel");
        AttackLabel = GetNode<Label>("AttackLabel");
        CostLabel = GetNode<Label>("CostLabel");

        GD.Print("BloodLabel value: " + BloodLabel.Text);
        GD.Print("AttackLabel value: " + AttackLabel.Text);
        GD.Print("CostLabel value: " + CostLabel.Text);

        AddThemeConstantOverride("margin_top", borderWidth);
		AddThemeConstantOverride("margin_left", borderWidth);
		AddThemeConstantOverride("margin_bottom", borderWidth);
		AddThemeConstantOverride("margin_right", borderWidth);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (blood_modifier <= initial_blood_value)
		{
			KillCard(this);
		}
	}

    public void KillCard(card_base targetCard)
    {
        // TODO: Play death animation here

		// TODO: Remove card visibility

		// TODO: Remove card from any decks it is a part of

		// TODO: Delete card once it is not referenced anywhere else

    }

    public int GetCurrentBloodValue()
}
