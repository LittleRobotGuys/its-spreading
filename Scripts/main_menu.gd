class_name main_menu
extends Control

@onready var new_game_button = $HBoxContainer/VBoxContainer/new_game_button as Button
@onready var load_button = $HBoxContainer/VBoxContainer/load_button as Button
@onready var options_button = $HBoxContainer/VBoxContainer/options_button as Button
@onready var quit_button = $HBoxContainer/VBoxContainer/quit_button as Button
@onready var menu_margin_container = $"." as MarginContainer
@onready var options_menu_container = $"../options_menu_container" as MarginContainer
@onready var options_back_button = $"../options_menu_container/VBoxContainer/back_button" as Button
@onready var new_game_scene = preload("res://Scenes/new_game.tscn") as PackedScene


func _ready():
	handle_connecting_signals()

func on_new_game_button_press():
	get_tree().change_scene_to_packed(new_game_scene)
	#print('new game button is connected')

#func on_load_button_press():
	#print('load button is connected')

func on_options_button_press():
	menu_margin_container.visible = false
	options_menu_container.visible = true
	#print('options button is connected')

func on_options_back_button_press():
	menu_margin_container.visible = true
	options_menu_container.visible = false

func on_quit_button_press():
	get_tree().quit()

func handle_connecting_signals():
	new_game_button.button_down.connect(on_new_game_button_press)
	#load_button.button_down.connect(on_load_button_press)
	options_button.button_down.connect(on_options_button_press)
	quit_button.button_down.connect(on_quit_button_press)
	options_back_button.button_down.connect(on_options_back_button_press)
