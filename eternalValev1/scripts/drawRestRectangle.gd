
extends Node2D


# Called when the node enters the scene tree for the first time.
func _ready():
	_draw()
	
	pass

func _draw():
	draw_rect(Rect2(0,0,1500,650), Color.LIGHT_SKY_BLUE, true)
	


func _on_button_pressed():
	pass # Replace with function body.
