extends Phase
class_name EnemyEndPhase

func BeginPhase():
	#foreach card under player control, trigger cards
	#discard hand
	Manager.TriggerNextPhase()
	
func NextPhase():
	return PlayerBeginPhase.new()
