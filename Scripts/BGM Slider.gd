extends HSlider


var bgm_bus = AudioServer.get_bus_index('BGM')

func _on_value_changed(value: float) -> void:
	AudioServer.set_bus_volume_db(bgm_bus,value)
	print(value)

	if value <= -24.5:
		AudioServer.set_bus_mute(bgm_bus, true)
	else:
		AudioServer.set_bus_mute(bgm_bus, false)






