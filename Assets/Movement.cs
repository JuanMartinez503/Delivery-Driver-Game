using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   [SerializeField]  float steerSpeed= 300;
    [SerializeField] float moveSpeed = 20;

    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag=="Speed"){
            moveSpeed= 30;
            Debug.Log("Speed active");
            Destroy(other.gameObject, 0.5f);
        } else if(other.tag=="Slow"){
            moveSpeed = 10;
            Debug.Log("Slow active");
        }
        }
    void OnCollisionEnter2D(Collision2D other) {
            moveSpeed=15;
        }

    // Update is called once per frame
    void Update()
  
    {  

       
        float controlSteer= Input.GetAxis("Horizontal") * steerSpeed *Time.deltaTime;
    float controlSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,controlSpeed,0);
        transform.Rotate(0,0,-controlSteer);
       
    }

}
