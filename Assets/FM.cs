using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FM : MonoBehaviour
{
    //This things positon should be as the same as the cars position
    [SerializeField] GameObject thingToFollow;
        void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
