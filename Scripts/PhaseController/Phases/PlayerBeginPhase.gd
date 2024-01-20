extends Phase
class_name PlayerBeginPhase

func BeginPhase():
	HUD.HUDTop.TriggerBanner()
	await Manager.get_tree().create_timer(1).timeout
	#Draw hand
	#reset UI: mana, new mana node...
	HUD.NewTurn()
	Manager.TriggerNextPhase()
	
func NextPhase():
	return PlayerPlayPhase.new()
