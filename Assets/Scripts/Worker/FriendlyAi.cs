using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyAi : MonoBehaviour
{
   public float speed = 3f;
    public GameObject target;



    private void Update(){
        if(target.transform.position != null){
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);
           
            }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "MyCoin"){
            target.transform.position = other.transform.position;

            Debug.Log("you trouch me talala");
        }
    }

 
}
