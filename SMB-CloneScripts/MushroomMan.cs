using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMan : MonoBehaviour
{
	var LeftPoint : float = 12;
var RightPoint : float = 18;
var Direction : int = 1;  //  1 = moving right, 2 = moving left


function Update()
	{
		if (Direction == 1)
		{
			transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
			Direction = 1;
		}

		if (this.transform.position.x > RightPoint)
		{
			Direction = 2;
		}

		if (Direction == 2)
		{
			transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
			Direction = 2;
		}

		if (this.transform.position.x < LeftPoint)
		{
			Direction = 1;
		}
	}


	//========================================


	var MushroomMan : GameObject;

function OnTriggerEnter(col : Collider)
	{
		this.GetComponent("BoxCollider").enabled = false;
		MushroomMan.GetComponent("MushroomMove").enabled = false;
		MushroomMan.transform.localScale -= new Vector3(0, 0.8, 0);
		MushroomMan.transform.localPosition -= new Vector3(0, 0.4, 0);
		yield WaitForSeconds(1);
		MushroomMan.transform.position = Vector3(0, -1000, 0);
	}
