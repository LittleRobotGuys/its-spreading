extends Phase
class_name PlayerEndPhase

func BeginPhase():
	#disable skip button
	HUD.SkipButton.disabled = true
	#foreach card under player control, trigger cards
	#discard hand
	Manager.TriggerNextPhase()
	
func NextPhase():
	return EnemyBeginPhase.new()
