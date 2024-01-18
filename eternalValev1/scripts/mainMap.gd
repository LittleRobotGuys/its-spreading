extends Node2D

@onready var to_battle = preload("res://Scenes/battle.tscn")
@onready var to_battle1 = preload('res://Scenes/battle1.tscn')
@onready var to_battle2 = preload('res://Scenes/battle2.tscn')
@onready var to_shop = preload("res://scenes/shop.tscn")
@onready var to_rest = preload("res://scenes/rest.tscn")
@onready var to_boss = preload("res://scenes/bossBattle.tscn")

func _on_button_pressed():
	get_tree().change_scene_to_packed(to_battle)

func _on_button_2_pressed():
	get_tree().change_scene_to_packed(to_battle1)
	
func _on_button_3_pressed():
	get_tree().change_scene_to_packed(to_battle2)
