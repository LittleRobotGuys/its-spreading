using Godot;
using System;

public partial class CardData : GodotObject
{
	/**
		Name,Type,Stats (Blood/Damage),CardText
		Juvenile Vampire,20/5d
		Bat,10/2d
		Villager
		Vassal
		Farm
		Sharp Teeth
		Silver Sword
		Vampiric Ritual
		Wolf
		Nosferatu
		Dracula
		Dhampir
		Failed Vampire
		Castle
		Mausoleum
	*/
	enum CardName = {JuvenileVampire, Bat, Villager, Vassal, Farm, SharpTeeth, 
	SilverSword, VampiricRitual, Wolf, Nosferatu, Dracular, Dhampir, FailedVampire, Castle, Mausoleum}
	
	public const var DATA = {
		JuvenileVampire: ["Minion", 20, 5, "This newly minted blood sucker is a mainstay in your spreading army"],
		
	}
}
