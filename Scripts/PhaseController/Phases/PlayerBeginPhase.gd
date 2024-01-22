extends Phase
class_name PlayerBeginPhase

func BeginPhase():
	HUD.HUDTop.TriggerBanner()
	await Manager.get_tree().create_timer(1).timeout
	#Draw hand
	
	#Add hand to UI
	var CardData = load("res://Scripts/CardData.cs")
	var CardPrefab = preload("res://card_base.tscn")
	var hand: Array
	for i in 3:
		var tmpData = (CardData.call("CloneCard", randi() % 20))
		var card = CardPrefab.instantiate()
		card.ReadInCardData(tmpData)
		hand.append(card)
	HUD.HUDBot.AddHand(hand)
	#reset UI: mana, new mana node...
	HUD.NewTurn()
	Manager.TriggerNextPhase()
	
func NextPhase():
	return PlayerPlayPhase.new()
