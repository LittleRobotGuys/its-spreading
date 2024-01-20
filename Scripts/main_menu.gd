class_name main_menu
extends Control

@onready var new_game_button =  $HBoxContainer/VBoxContainer/new_game_button as Button
@onready var load_button = $HBoxContainer/VBoxContainer/load_button as Button
@onready var options_button = $HBoxContainer/VBoxContainer/options_button as Button
@onready var quit_button = $HBoxContainer/VBoxContainer/quit_button as Button
@onready var menu_margin_container = $"." as MarginContainer
@onready var options_menu_container =  $"../options_menu" as VBoxContainer
@onready var options_back_button = $"../options_menu/back_button" as Button
@onready var new_game_scene = preload("res://Scenes/new_game.tscn") as PackedScene
@onready var fullscreen_button = $"../options_menu/HBoxContainer/fullscreen_button" as Button
@onready var windowed_button = $"../options_menu/HBoxContainer/windowed_button" as Button
@onready var load_menu = $"../load_menu" as Node

func _ready():
	handle_connecting_signals()
	randomize()

func on_new_game_button_press():
	get_tree().change_scene_to_packed(new_game_scene)

func _on_load_button_pressed() -> void:
	load_menu.visible = true
	menu_margin_container.visible = false
	options_menu_container.visible = false

func on_options_button_press():
	menu_margin_container.visible = false
	options_menu_container.visible = true
	load_menu.visible = false

func on_options_back_button_press():
	menu_margin_container.visible = true
	options_menu_container.visible = false
	load_menu.visible = false

func on_quit_button_press():
	get_tree().quit()

func handle_connecting_signals():
	new_game_button.button_down.connect(on_new_game_button_press)
	#load_button.button_down.connect()
	options_button.button_down.connect(on_options_button_press)
	quit_button.button_down.connect(on_quit_button_press)
	options_back_button.button_down.connect(on_options_back_button_press)

func _on_windowed_button_pressed() -> void:
	DisplayServer.window_set_mode(DisplayServer.WINDOW_MODE_WINDOWED)

func _on_fullscreen_button_pressed() -> void:
	DisplayServer.window_set_mode(DisplayServer.WINDOW_MODE_EXCLUSIVE_FULLSCREEN)

func _on_load_back_button_pressed() -> void:
	menu_margin_container.visible = true
	options_menu_container.visible = false
	load_menu.visible = false
