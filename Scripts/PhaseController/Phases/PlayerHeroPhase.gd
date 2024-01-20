extends Phase
class_name PlayerHeroPhase

func BeginPhase():
	#Add Hero to hand
	#Wait for card to be placed. I think could be done from the hero card.
	pass
	
func NextPhase():
	return EnemyHeroPhase.new()
