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

	public enum CardType { Creature, Action, Enhancement, Environment }


    public List<card_base> DATA = new List<card_base>()
	{
		/*
		 * Failed Vampire / Sick Villager	Creature	2m/10/5d	Attacks randomly each round / Blood counts as negative at end of combat
		 * Bat / Hound	Creature	1m/10/2d	
		 * Dhampir / Villager	Creature	2m/15/5d	
		 * Juvenile Vampire / Militia	Creature	2m/20/10d	
		 * Vampire / Vassal	Creature	3m/30/15d	
		 * Dracula / Abraham Van Helsing	Creature	5m/50/25d	Attacks all units in column in front of him / Van helsing only costs 4 mana splits total damage rounded up to all vampires on the board
		 */
        new card_base ("Juvenile Vampire", CardType.Creature, 2, 20, 5, "This newly minted blood sucker is a mainstay in your spreading army"),
        new card_base ("Militia", CardType.Creature, 2, 20, 5, "I hate vampires so hard!"),
		new card_base ("Bat", CardType.Creature, 1, 10, 2, "Squeak!"),
		new card_base ("Hound", CardType.Creature, 1, 10, 2, "Arf!"),
		new card_base ("Vampire", CardType.Creature, 3, 30, 15, "This grotesque monster is stronger than the juveniles"),
		new card_base ("Vassal", CardType.Creature, 3, 30, 15, "I hate vampires WAY HARDER!"),
		new card_base ("Dracula", CardType.Creature, 5, 50, 25, "Dracula attacks all units in column in front of him"),
		new card_base ("Abraham Van Helsing", CardType.Creature, 4, 50, 25, "Van Helsing evenly damages all vampires present"),

		/*
		 * Vampiric Ritual	Action	3m	Consume 2 lesser vampires to create 1 greater vampire
		 * Blood letting	Action	2m	Heal up to 10 missing blood from any unit on the battlefield
		 * Backstab	Action	1m	Deal 5 damage directly to any unit on the battlefield (double damage if the tile behind them in unoccupied)
		 * Wooden Stake	Action	1m	Deal 5 to any vampire
		 * Tactical Maneuver	Action	2m	Move 3 units you control to different spaces on the battlefield
		 * Spread disease	Action	3m	turn all villagers on the battlefield sick
		 * Sacrifice	Action	2m	Target 3x3 grid alll units inside take 10 damage
		 * Press on	Action	1m	Advance all friendly units who are able 1 space
		 * Inspire Fear / Inspire Courage	Action	2m	increase all friendly units attack by 5 until end of turn
		 * To Arms!	Action	3m	Consume 3 villagers to produce 1 Militia
		 */
		
		new card_base ("Vampiric Ritual", CardType.Action, 3, 0, 0,   "Consume 2 lesser vampires to create 1 greater vampire"),
        new card_base ("Blood letting", CardType.Action, 2, 0, 0,     "Heal up to 10 missing blood from any unit on the battlefield"),
        new card_base ("Backstab", CardType.Action, 1, 0, 0,          "Deal 5 damage directly to any unit on the battlefield (double damage if the tile behind them in unoccupied)"),
        new card_base ("Wooden Stake", CardType.Action, 1, 0, 0,      "Deal 5 to any vampire"),
        new card_base ("Tactical Maneuver", CardType.Action, 2, 0, 0, "Move 3 units you control to different spaces on the battlefield"),
        new card_base ("Spread Disease", CardType.Action, 3, 0, 0,    "Turn all Villagers on the battlefield SICK"),
        new card_base ("Sacrifice", CardType.Action, 2, 0, 0,         "Target 3x3 grid alll units inside take 10 damage"),
        new card_base ("Press on", CardType.Action, 1, 0, 0,          "Advance all friendly units who are able 1 space"),
        new card_base ("Inspire Fear", CardType.Action, 2, 0, 0,      "Increase all friendly units attack by 5 until end of turn"),
        new card_base ("To Arms!", CardType.Action, 3, 0, 0,          "Consume 3 villagers to produce 1 Militia"),

    };
}
