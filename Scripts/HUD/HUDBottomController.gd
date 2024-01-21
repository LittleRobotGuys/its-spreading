extends Node
class_name HUDBottomController

@export var CardContainer: HBoxContainer
@export var Card_Prefab: Node

func AddHand(cards):
	for card in cards:
		#TODO: Fix this to be real lol
		CardContainer.add_child(Card_Prefab.duplicate())
		await get_tree().create_timer(.3).timeout
		
func DiscardHand():
	for child in CardContainer.get_children(true):
		child.queue_free()
		await get_tree().create_timer(.1).timeout

func FocusHand():
	var hand: CenterContainer = get_child(0)
	(hand as CenterContainer).position.y -= 60
	
func UnfocusHand():
	var hand: CenterContainer = get_child(0)
	(hand as CenterContainer).position.y += 60
	
