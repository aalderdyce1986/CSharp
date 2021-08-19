using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
	//----------- COIN ROTATION SCRIPT -----------------

	function Update()
	{
		transform.Rotate(0, 2, 0, Space.World);
	}


	//----------- GLOBAL COIN SCRIPT -----------------

	import UnityEngine.UI;

	var CoinDisplay : GameObject;
static var CoinCount : int;
var InternalCoin : int;

function Update()
	{
		InternalCoin = CoinCount;
		CoinDisplay.GetComponent.< Text > ().text = "Coins: " + CoinCount;
	}


	//----------- COIN PICK UP SCRIPT -----------------



	function OnTriggerEnter(col : Collider)
	{
		transform.position = Vector3(0, -1000, 0);
		GlobalCoins.CoinCount += 1;
	}
}
