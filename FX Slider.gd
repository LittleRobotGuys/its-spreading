extends HSlider


var fx_bus = AudioServer.get_bus_index('FX')

func _on_value_changed(value: float) -> void:
	AudioServer.set_bus_volume_db(fx_bus,value)
	print(value)

	if value <= -24.5:
		AudioServer.set_bus_mute(fx_bus, true)
	else:
		AudioServer.set_bus_mute(fx_bus, false)
