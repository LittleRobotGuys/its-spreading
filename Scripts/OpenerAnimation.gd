extends Node2D

@onready var main_menu_scene = preload("res://Scenes/main_menu.tscn") as PackedScene


func _on_animated_sprite_2d_animation_finished() -> void:
	get_tree().change_scene_to_packed(main_menu_scene)
