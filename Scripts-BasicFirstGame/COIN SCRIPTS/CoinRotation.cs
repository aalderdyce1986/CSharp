using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotateSpeed = 7;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
