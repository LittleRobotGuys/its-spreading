using Godot;
using System;
using System.Collections.Generic;

public partial class CardData : GodotObject
{
	public enum CardType { Creature, Action, Enhancement, Environment }
	public enum CardAlignment { Vampire, Human, Neutral }

	/************ 
	 * This class is a stand-in.
	 * 
	 * Ideally, this class will have a DATA object like below, but it will be filled via other methods than hard-coded entries.
	 * CSV, JSON, or similar is likely the easiest route.
	 * 
	 * TODO: Add functions to add cards to the existing database via explicit lists and references to assets
	 * 
	 * 
	 * Hard-coding all of these cards is not ideal obviously and is not scalable, but for now this is the quickest path to victory.
	 * 
	 */
	public static List<card_base> DATA = new List<card_base>()
	{
		/*
		 * Failed Vampire / Sick Villager	Creature	2m/10/5d	Attacks randomly each round / Blood counts as negative at end of combat
		 * Bat / Hound	Creature	1m/10/2d	
		 * Dhampir / Villager	Creature	2m/15/5d	
		 * Juvenile Vampire / Militia	Creature	2m/20/10d	
		 * Vampire / Vassal	Creature	3m/30/15d	
		 * Dracula / Abraham Van Helsing	Creature	5m/50/25d	Attacks all units in column in front of him / Van helsing only costs 4 mana splits total damage rounded up to all vampires on the board
		 */
		/* 000 */ new card_base ("TEST_Creature", CardType.Creature, 1, 10, 2, "Pew pew!", CardAlignment.Human, "Flavor Text!"),
		/* 001 */ new card_base ("Juvenile Vampire", CardType.Creature, 2, 20, 5, "This newly minted initial_blood_value sucker is a mainstay in your spreading army", CardAlignment.Vampire),
		/* 002 */ new card_base ("Militia", CardType.Creature, 2, 20, 5, "I hate vampires so hard!", CardAlignment.Human),
		/* 003 */ new card_base ("Bat", CardType.Creature, 1, 10, 2, "Squeak!", CardAlignment.Vampire, "Squee!"),
		/* 004 */ new card_base ("Hound", CardType.Creature, 1, 10, 2, "Arf!", CardAlignment.Human, "Woof!"),
		/* 005 */ new card_base ("Vampire", CardType.Creature, 3, 30, 15, "This grotesque monster is stronger than the juveniles", CardAlignment.Vampire),
		/* 006 */ new card_base ("Vassal", CardType.Creature, 3, 30, 15, "I hate vampires WAY HARDER!", CardAlignment.Human),
		/* 007 */ new card_base ("Dracula", CardType.Creature, 5, 50, 25, "Dracula attacks all units in column in front of him", CardAlignment.Vampire),
		/* 008 */ new card_base ("Abraham Van Helsing", CardType.Creature, 4, 50, 25, "Van Helsing evenly damages all vampires present", CardAlignment.Human),

		/*
		 * Vampiric Ritual	Action	3m	Consume 2 lesser vampires to create 1 greater vampire
		 * Blood letting	Action	2m	Heal up to 10 missing initial_blood_value from any unit on the battlefield
		 * Backstab	Action	1m	Deal 5 damage directly to any unit on the battlefield (double damage if the tile behind them in unoccupied)
		 * Wooden Stake	Action	1m	Deal 5 to any vampire
		 * Tactical Maneuver	Action	2m	Move 3 units you control to different spaces on the battlefield
		 * Spread disease	Action	3m	turn all villagers on the battlefield sick
		 * Sacrifice	Action	2m	Target 3x3 grid alll units inside take 10 damage
		 * Press on	Action	1m	Advance all friendly units who are able 1 space
		 * Inspire Fear / Inspire Courage	Action	2m	increase all friendly units attack by 5 until end of turn
		 * To Arms!	Action	3m	Consume 3 villagers to produce 1 Militia
		 */
		
		/* 009 */ new card_base ("Vampiric Ritual", CardType.Action, 3, 0, 0,   "Consume 2 lesser vampires to create 1 greater vampire", CardAlignment.Vampire),
		/* 010 */ new card_base ("Blood letting", CardType.Action, 2, 0, 0,     "Heal up to 10 missing blood from any unit on the battlefield", CardAlignment.Vampire),
		/* 011 */ new card_base ("Backstab", CardType.Action, 1, 0, 0,          "Deal 5 damage directly to any unit on the battlefield (double damage if the tile behind them in unoccupied)", CardAlignment.Neutral),
		/* 012 */ new card_base ("Wooden Stake", CardType.Action, 1, 0, 0,      "Deal 5 to any vampire", CardAlignment.Human),
		/* 013 */ new card_base ("Tactical Maneuver", CardType.Action, 2, 0, 0, "Move 3 units you control to different spaces on the battlefield", CardAlignment.Human),
		/* 014 */ new card_base ("Spread Disease", CardType.Action, 3, 0, 0,    "Turn all Villagers on the battlefield SICK", CardAlignment.Vampire),
		/* 015 */ new card_base ("Sacrifice", CardType.Action, 2, 0, 0,         "Target 3x3 grid alll units inside take 10 damage", CardAlignment.Vampire),
		/* 016 */ new card_base ("Press on", CardType.Action, 1, 0, 0,          "Advance all friendly units who are able 1 space", CardAlignment.Human),
		/* 017 */ new card_base ("Inspire Fear", CardType.Action, 2, 0, 0,      "Increase all friendly units attack by 5 until end of turn", CardAlignment.Vampire),
		/* 018 */ new card_base ("To Arms!", CardType.Action, 3, 0, 0,          "Consume 3 villagers to produce 1 Militia", CardAlignment.Human),


		/*
		 * Sharp Teeth / Torch	Enhancement	1m	Permenant +1 to damage
		 * Silver Sword / Crucifix	Enhancement	3m	Permenant +5 to damage
		 */
		 

		/* 019 */ new card_base ("Sharp Teeth", CardType.Enhancement, 1, 0, 0,     "+1 Damage", CardAlignment.Vampire),
		/* 020 */ new card_base ("Torch", CardType.Enhancement, 1, 0, 0,           "+1 Damage", CardAlignment.Human),


		/* 
		 * Farm	Environment	2m	increase all adjacent farmers attack by 1 at end of turn
		 * Castle	Environment	5m	Bolsters defence of adjacent vampire cards, reduce damage taken by 2
		 * Mausoleum	Environment	5m	If surrounded by units return one unit from graveyard to battlefield
		 * Hospital	Environment	3m	Heals surrounding units 5 hp per turn
		 * Bloodwood Tree / Holy Water Spring	Environment	3m	Occupy 1 space on the enemy board
		 */

		/* 021 */ new card_base ("Castle", CardType.Environment, 2, 0, 0,            "Bolsters defence of adjacent vampire cards, reduce damage taken by 2", CardAlignment.Vampire),
		/* 022 */ new card_base ("Farm", CardType.Environment, 2, 0, 0,              "Bolsters defence of adjacent vampire cards, reduce damage taken by 2", CardAlignment.Human),
		/* 023 */ new card_base ("Mausoleum", CardType.Environment, 5, 0, 0,         "If surrounded by units return one unit from graveyard to battlefield", CardAlignment.Vampire),
		/* 024 */ new card_base ("Hospital", CardType.Enhancement, 3, 0, 0,          "Heals surrounding units 5 hp per turn", CardAlignment.Human),
		/* 025 */ new card_base ("Bloodwood Tree", CardType.Enhancement, 1, 0, 0,    "Environment	3m	Occupy 1 space on the enemy board", CardAlignment.Vampire),
		/* 026 */ new card_base ("Holy Water Spring", CardType.Enhancement, 1, 0, 0, "Environment	3m	Occupy 1 space on the enemy board", CardAlignment.Human),
	};

	public card_base GetRandomCardOfAlignement(CardAlignment alignement)
	{
		card_base card = CloneCard((int)GD.Randi() % DATA.Count);
		if (card.GetAlignment() == alignement)
		{
			return card;
		}
		else
		{
			card.RemoveCardFromMemory();
			return GetRandomCardOfAlignement(alignement);
		}
	}

	public card_base GetRandomCardOfAlignementAndType(CardAlignment alignement, CardType cardType)
	{
		card_base card = CloneCard((int)GD.Randi() % DATA.Count);
		if (card.GetAlignment() == alignement && card.GetCardType() == cardType)
		{
			return card;
		}
		else
		{
			card.RemoveCardFromMemory();
			return GetRandomCardOfAlignementAndType(alignement, cardType);
		}
	}


	public static card_base CloneCard(int dataIndex)
	{
		if (0 < dataIndex && dataIndex < DATA.Count)
		{
			var card = (card_base) DATA[dataIndex].Clone();
			card.uid = GameState.GetUid();
		}

		return null;
	}
}
