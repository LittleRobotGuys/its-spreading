extends Node2D

@onready var to_battle = preload("res://Scenes/battle.tscn")
@onready var to_battle1_1 = preload("res://Scenes/battle1.tscn")
@onready var to_battle1_2 = preload("res://Scenes/battle2.tscn")
@onready var to_shop = preload("res://scenes/shop.tscn")
@onready var to_rest = preload("res://scenes/rest.tscn")
@onready var to_boss = preload("res://scenes/bossBattle.tscn")
@onready var to_battle2_1 = preload("res://scenes/battle2_1.tscn")
@onready var to_mystery_2_2 = preload("res://scenes/mystery2_2.tscn")
@onready var to_shop_3_1 = preload("res://scenes/shop3_1.tscn")
@onready var to_elite_battle_3_2 = preload("res://scripts/eliteBattle3_2.tscn")
@onready var to_battle_3_3 = preload("res://scenes/battle3_3.tscn")


#Top 3 functions for row 1 encounters
func _on_button_1_pressed():
	get_tree().change_scene_to_packed(to_battle)

func _on_button_2_pressed():
	get_tree().change_scene_to_packed(to_battle1_1)
	
func _on_button_3_pressed():
	get_tree().change_scene_to_packed(to_battle1_2)
	
# Next 2 functions for row 2 encounters
func _on_battle_2_1_pressed():
	get_tree().change_scene_to_packed(to_battle2_1)
	
func _on_mystery_2_2_pressed():
	get_tree().change_scene_to_packed(to_mystery_2_2)

# Following 3 functions are for row 3 encounters
func _on_shop_3_1_pressed():
	get_tree().change_scene_to_packed(to_shop_3_1)
	
func _on_elite_battle_3_2_pressed():
	get_tree().change_scene_to_packed(to_elite_battle_3_2)

func _on_battle_3_3_pressed():
	get_tree().change_scene_to_packed(to_battle_3_3)
