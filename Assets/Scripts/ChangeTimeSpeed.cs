using UnityEngine;
using System.Collections;

public class ChangeTimeSpeed : MonoBehaviour 
{
	private const float upperLimit = 10.0f;
	private const float lowerLimit = 0.0f;
	private const float timeStep = 0.5f;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.X))
		{
			if (Time.timeScale >= upperLimit)
				return;

			Time.timeScale += timeStep;
		}

		else if (Input.GetKeyDown (KeyCode.Z))
		{
			if (Time.timeScale <= lowerLimit)
				return;

			Time.timeScale -= timeStep;
		}
	}
}
