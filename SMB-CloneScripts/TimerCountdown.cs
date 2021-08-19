using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountdown : MonoBehaviour
{
	import UnityEngine.UI;

	var TotalTime : int = 301;
var TimeDisplay : GameObject;
var CalculatingTime : int;
var DeathSound : AudioSource;
var LevelMusic : GameObject;
var CamFollow : GameObject;
var ThePlayer : GameObject;
var KeepZero : int;

function Update()
	{
		if (KeepZero == 0)
		{
			TimeDisplay.GetComponent.< Text > ().text = "" + TotalTime;
		}

		if (CalculatingTime == 0)
		{
			DeductTime();
		}

		if (TotalTime == 0)
		{
			TimeUp();
		}
	}

	function DeductTime()
	{
		CalculatingTime = 1;
		TotalTime -= 1;
		yield WaitForSeconds(1);
		CalculatingTime = 0;
	}

	function TimeUp()
	{
		TotalTime -= 1;
		KeepZero = 1;
		TimeDisplay.GetComponent.< Text > ().text = "0";
		GlobalLives.LivesAmount -= 1;
		LevelMusic.SetActive(false);
		DeathSound.Play();
		CamFollow.GetComponent("CameraFollow").enabled = false;
		ThePlayer.GetComponent("ThirdPersonUserControl").enabled = false;
		ThePlayer.GetComponent("ThirdPersonCharacter").enabled = false;
		//ThePlayer.transform.localScale -= new Vector3(0.0, 0.7, 0.0);
		ThePlayer.GetComponent("CapsuleCollider").enabled = false;
		yield WaitForSeconds(3);
		Application.LoadLevel(4);
	}
}
