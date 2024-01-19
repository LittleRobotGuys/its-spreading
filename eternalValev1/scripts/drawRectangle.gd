extends Node2D


# Called when the node enters the scene tree for the first time.
func _ready():
	_draw()

func _draw():
	draw_rect(Rect2(0,0,1500,650), Color.BISQUE, true)
	
