using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUIandGameOver : MonoBehaviour
{

	//GlobalLives

	static var LivesAmount : int = 3;
var InternalLives : int;
var LifeTextBox : GameObject;

function Update()
	{
		InternalLives = LivesAmount;
		LifeTextBox.GetComponent.< Text > ().text = "" + InternalLives;

		if (InternalLives == 0)
		{
			GameOverScene();
		}

	}

	function GameOverScene()
	{
		yield WaitForSeconds(2.9);
		Application.LoadLevel(3);
	}


	//GameOverToMenu

	function Start()
	{
		yield WaitForSeconds(4);
		GlobalLives.LivesAmount += 3;
		Application.LoadLevel(2);
	}


	//MenuButtons

	function PlayGame()
	{
		Application.LoadLevel(0);
	}

	function QuitGame()
	{
		Application.Quit();
	}
