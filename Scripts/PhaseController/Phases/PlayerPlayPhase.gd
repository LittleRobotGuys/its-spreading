extends Phase
class_name PlayerPlayPhase

func BeginPhase():
	#Enable skip button
	HUD.SkipButton.disabled = false
	#Enable hand interaction
	pass
	
func NextPhase():
	return PlayerEndPhase.new()
