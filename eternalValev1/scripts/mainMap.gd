extends Node2D

@onready var to_battle = preload("res://Scenes/battle.tscn")
@onready var to_battle1 = preload('res://Scenes/battle1.tscn')

func _on_button_pressed():
	get_tree().change_scene_to_packed(to_battle)

func _on_button_2_pressed():
	get_tree().change_scene_to_packed(to_battle1)
