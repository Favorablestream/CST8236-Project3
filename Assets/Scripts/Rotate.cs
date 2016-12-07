using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	public float RotationPeriod;

	private const float speedFactor = 5.0f;

	void Update () 
	{
		float rotationSpeed = 0.0f;

		if (RotationPeriod != 0.0f)
			rotationSpeed = speedFactor / RotationPeriod;
		
		gameObject.transform.Rotate (new Vector3 (0.0f, rotationSpeed * Time.deltaTime, 0.0f));
	}
}
