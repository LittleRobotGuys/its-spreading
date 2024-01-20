extends Phase
class_name PlayerPlayPhase

func BeginPhase():
	#Enable skip button
	HUD.SkipButton.disabled = false
	#Enable hand interaction?
	
func NextPhase():
	return PlayerEndPhase.new()
