using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFireball : MonoBehaviour
{

	//Fireball Rotate:

	function Update()
	{
		transform.Rotate(0, 0, -1, Space.World);
	}


	//=============


	//Ledge Movement:

	var ResetPoint : float;
var CurrentPoint : float;

function Update()
	{
		ResetPoint = 6.5;
		CurrentPoint = transform.position.y;
		if (CurrentPoint >= ResetPoint)
		{
			transform.position.y = -3.5;
		}
		transform.Translate(Vector3.up * Time.deltaTime);
	}
}
