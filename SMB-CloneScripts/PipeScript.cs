using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
	var PipeEntry : GameObject;
var StoodOn : int;


function OnTriggerEnter(col : Collider)
	{
		StoodOn = 1;
	}

	function OnTriggerExit(col : Collider)
	{
		StoodOn = 0;
	}


	function Update()
	{
		if (Input.GetButtonDown("GoDown"))
		{
			if (StoodOn == 1)
			{
				//GameObject.Find("FPSController").GetComponent("FirstPersonController").enabled=false;
				transform.position = Vector3(0, -1000, 0);
				WaitingForPipe();
			}
		}
	}

	function WaitingForPipe()
	{
		PipeEntry.GetComponent("Animator").enabled = true;
		yield WaitForSeconds(2);
		PipeEntry.GetComponent("Animator").enabled = false;
		//GameObject.Find("FPSController").GetComponent("FirstPersonController").enabled=true;
	}

	var MainCam : GameObject;
var SecondCam : GameObject;
var MainPlayer : GameObject;

SecondCam.SetActive(true);
MainCam.SetActive(false);
MainPlayer.transform.position = Vector3(11, -17, 0.5)

}
