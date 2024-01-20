extends Node
class_name Phase
var PhaseName: String
var Manager: PhaseManager
var HUD: HUDController

func BeginPhase():
	pass
	
func NextPhase():
	pass

func GetName():
	return PhaseName
