using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            GlobalCoins.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
