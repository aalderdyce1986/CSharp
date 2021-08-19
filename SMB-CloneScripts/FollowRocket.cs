using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRocket : MonoBehaviour
{
   var Target : Transform;
var Distance : float = 14;
var CameraY : float = 12;


   function Update()
    {
        transform.position.z = Target.position.z - Distance;
        transform.position.x = Target.position.x + 7;
    }


    function LateUpdate()
    {
        GetComponent.< Camera > ().main.transform.position.y = CameraY;

    }
 
}
