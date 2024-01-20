extends Phase
class_name EnemyHeroPhase

func BeginPhase():
	#Add Hero to hand
	#Wait for card to be placed. I think could be done from the hero card.
	#or could be in process. wait until hand is empty then trigger next phase
	pass
	
func NextPhase():
	var np: Phase #Randomly select turn
	return np
