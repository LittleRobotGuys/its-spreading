extends Node
class_name HUDController

@export var HUDTop: HUDTopController
@export var targetBloodValue: int = 20
@export var bloodBar: TextureProgressBar
@export var bloodTxt: Label
@export var manaObjs: HBoxContainer
var manaTotal: int
var manaCurrent: int
@export var manaImg: Texture2D
@export var UsedManaImg: Texture2D
@export var SkipButton: Button

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	LerpBloodFillBar(delta)

func UseMana(amountUsed: int):
	for i in amountUsed:
		(manaObjs.get_child(i) as TextureRect).texture = UsedManaImg
	manaCurrent -= amountUsed

func NewTurn():
	if (manaTotal < 6):
		manaTotal += 1
	EnableManaNodes()

func EnableManaNodes():
	for i in manaTotal:
		var tmp: TextureRect = manaObjs.get_child(i)
		(tmp as TextureRect).visible = true
		(tmp as TextureRect).texture = manaImg

func AddBlood():
	targetBloodValue += 5

func LerpBloodFillBar(delta):
	if (int (bloodBar.value) == targetBloodValue):
		bloodBar.value = targetBloodValue
	else:
		bloodBar.value = lerp(bloodBar.value, targetBloodValue as float, delta / (Distance(bloodBar.value,targetBloodValue)/100))
	bloodTxt.text = String.num(bloodBar.value)

func Distance(a: float, b: float):
	if (a > b):
		return a - b
	else:
		return b - a

