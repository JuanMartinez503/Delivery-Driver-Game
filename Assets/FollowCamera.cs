using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
 
    // Update is called once per frame
    [SerializeField]GameObject thingToFollow;
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-40);
    }
}
