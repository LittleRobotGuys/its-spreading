using Godot;
using System;
using static CardData;

public partial class card_base : MarginContainer, ICloneable
{
	private string DefaultCardInfo = "UNINITIALIZED CARD INFO";
	private string CardInfo;
	private string CardFlavorText;
	private CardAlignment cardAlignment;
	Image CardImage = null;
	private string name;
	private CardType cardType;
	private int cost;
	private int initial_blood_value;
	private int blood_modifier;
	private int attack;
	private Label BloodLabel, AttackLabel, CostLabel;
	private Deck cardDeck;

	private int borderWidth = 5;

	public int uid { get; set; }

	public card_base(){
		this.name = "Juvenile Vampire";
		this.cardType = CardType.Creature;
		this.cost = 2;
		this.initial_blood_value = 20;
		this.attack = 5;
		this.CardInfo = "This newly minted initial_blood_value sucker is a mainstay in your spreading army";
		this.CardFlavorText = "";
		this.cardAlignment = CardAlignment.Vampire;
	}
	public card_base(string name, CardType type, int cost, int blood, int attack, string cardInfo, CardAlignment alignment, string flavorText = "" )
	{
		this.name = name;
		this.cardType = type;
		this.cost = cost;
		this.initial_blood_value = blood;
		this.attack = attack;
		this.CardInfo = cardInfo == null ? cardInfo : DefaultCardInfo;
		this.CardFlavorText = flavorText;
		this.cardAlignment = alignment;
	}
	
	public void ReadInCardData(card_base card)
	{
		this.name = card.name;
		this.cardType = card.cardType;
		this.cost = card.cost;
		this.initial_blood_value = card.initial_blood_value;
		this.attack = card.attack;
		this.CardInfo = card.CardInfo == null ? card.CardInfo : DefaultCardInfo;
		this.CardFlavorText = card.CardFlavorText;
		this.cardAlignment = card.cardAlignment;
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Created a card named " + this.name + "!");

		switch (cardType)
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
		
		BloodLabel = GetNode<Label>("%BloodLabel");
		AttackLabel = GetNode<Label>("%AttackLabel");
		CostLabel = GetNode<Label>("%CostLabel");

		BloodLabel.Text = "" + initial_blood_value;
		AttackLabel.Text = "" + attack;
		CostLabel.Text = "" + cost;
		
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
		RemoveCardFromMemory();

	}

	public void RemoveCardFromMemory()
	{
		GameState.RemoveUidFromState(this.uid);
	}

	public int GetCurrentBloodValue()
	{
		return blood_modifier + initial_blood_value;
	}

	public object Clone()
	{
		return this.MemberwiseClone();
	}

	public CardAlignment GetAlignment()
	{
		return this.cardAlignment;
	}

	public CardType GetCardType()
	{
		return this.cardType;
	}
}
