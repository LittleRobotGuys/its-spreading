extends Phase
class_name EnemyBeginPhase

func BeginPhase():
	#Draw hand
	#reset UI: mana, new mana node...
	Manager.TriggerNextPhase()
	
func NextPhase():
	return EnemyPlayPhase.new()
