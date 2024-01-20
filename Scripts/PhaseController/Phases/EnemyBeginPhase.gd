extends Phase
class_name EnemyBeginPhase

func BeginPhase():
	HUD.HUDTop.TriggerBanner()
	await Manager.get_tree().create_timer(1).timeout
	#Draw hand
	
	#reset enemy status: mana, new mana node...
	Manager.TriggerNextPhase()
	
func NextPhase():
	return EnemyPlayPhase.new()
