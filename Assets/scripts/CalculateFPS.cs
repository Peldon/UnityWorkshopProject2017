using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateFPS : MonoBehaviour {

	int frames = 0;
	float seconds = 0f;

	void Update () {
		frames = frames + 1;
		seconds = seconds + Time.deltaTime;
		float fps = frames / seconds;
		Debug.Log (fps);
	}
}
