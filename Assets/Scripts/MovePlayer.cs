using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{
	private Rigidbody playerBody = null;
	private const float movementForce = 15.0f;

	void Start ()
	{
		playerBody = GetComponent <Rigidbody> ();
		if (playerBody == null)
			throw new UnityException ("Player rigidbody is null");
	}

	void Update () 
	{
		Vector3 totalForce = Vector3.zero;

		if (Input.GetKey (KeyCode.W))
			totalForce.z = movementForce;
		
		else if (Input.GetKey (KeyCode.A))
			totalForce.x = -movementForce;
		
		else if (Input.GetKey (KeyCode.S))
			totalForce.z = -movementForce;
		
		else if (Input.GetKey (KeyCode.D))
			totalForce.x = movementForce;

		else
			return;
		
		playerBody.AddForce (totalForce);
	}
}
