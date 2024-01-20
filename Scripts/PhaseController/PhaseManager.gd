extends Node
class_name PhaseManager

var currentPhase: Phase
var HUD: HUDController

# Called when the node enters the scene tree for the first time.
func _ready():
	HUD = get_node("../HUDCanvas")
	currentPhase = PlayerBeginPhase.new()
	currentPhase.Manager = self
	currentPhase.HUD = HUD
	currentPhase.BeginPhase()

func TriggerNextPhase():
	currentPhase = currentPhase.NextPhase()
	currentPhase.Manager = self
	currentPhase.HUD = HUD
	currentPhase.BeginPhase()
