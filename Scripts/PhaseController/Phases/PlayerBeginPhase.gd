extends Phase
class_name PlayerBeginPhase

func BeginPhase():
	#Draw hand
	#reset UI: mana, new mana node...
	HUD.NewTurn()
	Manager.TriggerNextPhase()
	
func NextPhase():
	return PlayerPlayPhase.new()
