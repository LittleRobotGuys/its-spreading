extends Node

@export var bannerObj: TextureRect
@export var bannerTxt: Label
@export var animationPlayer: AnimationPlayer

# Called when the node enters the scene tree for the first time.
func _ready():
	#animationPlayer.play("BannerDownTransition")
	pass

# Called every frame. 'delta' is $BannerAnimationthe elapsed time since the previous frame.
func _process(delta):
	pass

func TriggerBanner():
	animationPlayer.play("BannerUpTransition")


func _on_animation_player_animation_finished(anim_name):
	if (anim_name == "BannerUpTransition"):
		if (bannerTxt.text == "Your Turn"):
			bannerTxt.text = "Enemy Turn"
		else:
			bannerTxt.text = "Your Turn"

		animationPlayer.play("BannerDownTransition")
