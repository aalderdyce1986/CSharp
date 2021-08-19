using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUpShroom : MonoBehaviour
{

	var LifeSound : AudioSource;

function OnTriggerEnter(col : Collider)
	{
		if (col.gameObject.tag == "Player")
		{
			this.transform.position = Vector3(0, -1000, 0);
			LifeSound.Play();
			GlobalLives.LivesAmount += 1;
		}
	}
}
