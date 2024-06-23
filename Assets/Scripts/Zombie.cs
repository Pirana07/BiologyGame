using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] private float attackDamage = 20f;
    [SerializeField] private float attackSpeed = 2f;
    private float canAttack;
    private Transform target;



    private void Update(){
        if(target != null){
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
           
            }
    }

         private void OnCollisionEnter2D (Collision2D other){
        if(other.gameObject.tag == "Player"){
           if(attackSpeed <= canAttack){
            other.gameObject.GetComponent<Playerhealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;
        } else{
                canAttack += Time.deltaTime;
            }
        }     
    
        if(other.gameObject.tag == "Worker"){
           if(attackSpeed <= canAttack){
            GetComponent<FriendHealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;
        } else{
                canAttack += Time.deltaTime;
            }
        }     
         }





       
       
        private void OnCollisionStay2D (Collision2D other){
        if(other.gameObject.tag == "Player"){
           if(attackSpeed <= canAttack){
            other.gameObject.GetComponent<Playerhealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;
         SoundManager2.sndMan2.PlayCoinSound();

        } else{
                canAttack += Time.deltaTime;
            }
        }    
        if(other.gameObject.tag == "Worker"){
           if(attackSpeed <= canAttack){
            GetComponent<FriendHealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;

        } else{
                canAttack += Time.deltaTime;
            }
        }     
    }



    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            target = other.transform;

            Debug.Log("you trouch me talala");
        }
            if(other.gameObject.tag == "Worker"){
            target = other.transform;

            Debug.Log("you trouch me talala");
            }
    }

    private void OnTriggerExit2D(Collider2D other){
             if(other.gameObject.tag == "Player"){
            target = null;
        }
         if(other.gameObject.tag == "Worker"){
            target = null;
         }

    }

  


}
