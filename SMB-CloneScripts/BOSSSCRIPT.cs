using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSSSCRIPT : MonoBehaviour
{
	//boss camera freeze:

	var MainCam : GameObject;
var BackWall : GameObject;

function OnTriggerEnter()
	{
		MainCam.GetComponent("CameraFollow").enabled = false;
		BackWall.SetActive(true);
	}


	//boss death:

	function OnTriggerEnter(col : Collider)
	{
		this.GetComponent("BoxCollider").enabled = false;
		MushroomMan.GetComponent("MushroomManMove").enabled = false;
		MushroomMan.transform.localScale -= new Vector3(0, 0, 1.8);
		MushroomMan.transform.localPosition -= new Vector3(0, 0, 1.4);
		GlobalScore.CurrentScore += 100;
		yield WaitForSeconds(1);
		MushroomMan.transform.position = Vector3(0, -1000, 0);
		yield WaitForSeconds(2);
		Application.LoadLevel(6);
	}
}
