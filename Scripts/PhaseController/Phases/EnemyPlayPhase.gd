extends Phase
class_name EnemyPlayPhase

func BeginPhase():
	#AI.take turn
	Manager.TriggerNextPhase()
	
func NextPhase():
	return EnemyEndPhase.new()
