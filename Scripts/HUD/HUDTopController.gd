extends Node
class_name HUDTopController

@export var bannerObj: TextureRect
@export var bannerTxt: Label
@onready var animationPlayer = get_node("TopBanner/BannerAnimator")
var bannerDown: bool

# Called when the node enters the scene tree for the first time.
func _ready():
	animationPlayer.play("BannerDownTransition")
	bannerDown = true
	pass

func TriggerBanner():
	if (bannerDown):
		animationPlayer.play("BannerUpTransition")
	else:
		animationPlayer.play("BannerDownTransition")
	bannerDown = !bannerDown


func _on_animation_player_animation_finished(anim_name):
	if (anim_name == "BannerUpTransition"):
		if (bannerTxt.text == "Your Turn"):
			bannerTxt.text = "Enemy Turn"
		else:
			bannerTxt.text = "Your Turn"

		animationPlayer.play("BannerDownTransition")
