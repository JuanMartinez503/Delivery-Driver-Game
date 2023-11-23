using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage=false;
  [SerializeField] float destroyDelay = 0.5f;
  [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
  [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

SpriteRenderer spriteRenderer;

  void Start(){
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("You have collided");
  }
   void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Package"&& !hasPackage){
      Debug.Log("You have picked up a package");
      spriteRenderer.color= hasPackageColor;

      Destroy(other.gameObject,destroyDelay);
      hasPackage=true;
    } else if(other.tag=="Customer"&& hasPackage){
      Debug.Log("The package has been delivered to the customer");
      spriteRenderer.color = noPackageColor;
      Destroy(other.gameObject, destroyDelay);
      hasPackage=false;
    }
  }
}
