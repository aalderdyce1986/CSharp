using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEATHandMUSHROOM : MonoBehaviour
{
	//MushroomCollect

	var GrowSound : AudioSource;
var ThePlayer : GameObject;

function OnTriggerEnter(col : Collider)
	{
		if (col.gameObject.tag == "Player")
		{
			this.transform.position = Vector3(0, -1000, 0);
			GrowSound.Play();
			ThePlayer.transform.localScale += new Vector3(0.3, 0.3, 0.3);
		}
	}




	//Level01_Load

	function Start()
	{
		yield WaitForSeconds(1);
		Application.LoadLevel(1);
	}




	//Level01Death

	var DeathSound : AudioSource;
var LevelMusic : GameObject;

function OnTriggerEnter(col : Collider)
	{
		LevelMusic.SetActive(false);
		DeathSound.Play();
		yield WaitForSeconds(3);
		Application.LoadLevel(0);
	}
}
