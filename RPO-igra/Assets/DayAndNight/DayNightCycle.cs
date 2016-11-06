using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour
{

	public Light DirectionLight;
	public Texture2D LightColor;
	public Texture2D SkyColor;
	public Texture2D AmbientColor;
	public float TimeOfDay = 1;
	[Range(0, 1)]
	public float Timer = 0;
	private float timeTemp = 0;
	private float fade = 0;
	public bool FadeTime = true;
	public float MaxFade = 20;

	
	void Start ()
	{
		timeTemp = Time.time;
		fade = Timer;
	}

	void Update ()
	{
		if (Network.isServer || (!Network.isClient && !Network.isServer)) {
			if (FadeTime) {
				float timeperfade = TimeOfDay / MaxFade;
				if (Time.time >= timeTemp + timeperfade) {
					timeTemp = Time.time;	
					fade += 1.0f / MaxFade;
				}
				if (fade > 1.0f) {
					fade = 0;
					Timer = 0;
				}

				Timer += (fade - Timer) / 10f;
			
			} else {
				if (Timer > 1) {
					Timer = 0;
				} else {
					Timer += (1.0f * Time.deltaTime) * (1.0f / TimeOfDay);
					
				}
			}
		}
		
		Color skyColor = SkyColor.GetPixelBilinear (Timer, 0);
		RenderSettings.skybox.SetColor ("_Tint", skyColor);
		RenderSettings.fogColor = skyColor;
		RenderSettings.ambientLight = AmbientColor.GetPixelBilinear (Timer, 0);
		DirectionLight.color = LightColor.GetPixelBilinear (Timer, 0);
		
	}
}
