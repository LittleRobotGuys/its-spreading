using Godot;
using System;
using System.Collections.Generic;

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
	
	public const List<card_base> DATA = {
        card_base JuvenileVampire = new card_base ("Creature", 2, 20, 5, "This newly minted blood sucker is a mainstay in your spreading army"),

    }
}
