extends Node2D

@onready var to_main = preload("res://scenes/mainMap(git).tscn")

func _on_button_pressed():
	get_tree().change_scene_to_packed(to_main)
