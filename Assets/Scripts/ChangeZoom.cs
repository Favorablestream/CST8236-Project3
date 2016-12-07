using UnityEngine;
using System.Collections;
using System.Configuration;

public class ChangeZoom : MonoBehaviour 
{
	private Camera playerCamera = null;

	private const float zoomInLimit = 0.0f;
	private const float zoomOutLimit = -5.0f;
	private const float positionStep = 0.5f;

	void Start () 
	{
		playerCamera = GetComponentInChildren <Camera> ();
		if (playerCamera == null)
			throw new UnityException ("Camera is null");
	}
	
	void Update () 
	{
		Vector3 cameraPosition = playerCamera.transform.localPosition;

		if (Input.GetKeyDown (KeyCode.E))
		{
			if (cameraPosition.z >= zoomInLimit)
				return;

			cameraPosition.z += positionStep;
		}

		else if (Input.GetKeyDown (KeyCode.Q))
		{
			if (cameraPosition.z <= zoomOutLimit)
				return;

			cameraPosition.z -= positionStep;
		}

		else
			return;

		playerCamera.transform.localPosition = cameraPosition;
	}
}
