using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using UnityEditor.VersionControl;

public class Orbit : MonoBehaviour 
{
	public GameObject ObjectToOrbit;
	public float OrbitalPeriod;

	private const float speedFactor = 3.0f;

	void Update () 
	{
		if (ObjectToOrbit == null)
			return;
		
		float rotationSpeed = 0.0f;

		if (OrbitalPeriod != 0.0f)
			rotationSpeed = speedFactor / OrbitalPeriod;

		gameObject.transform.RotateAround (ObjectToOrbit.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
