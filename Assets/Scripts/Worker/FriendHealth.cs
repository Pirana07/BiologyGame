using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendHealth : MonoBehaviour
{
   private float health = 0f;
   [SerializeField] private float maxHealth = 100f;
   [SerializeField] private float attackDamage = 5f;
   [SerializeField] private float attackSpeed = 2f;
    private float canAttack;



   private void Start(){
    health = maxHealth;

   }

    public void UpdateHealth(float mod){
        health += mod;

        if(health > maxHealth){
            health = maxHealth;
        } else if(health <= 0f){
            health = 0f;
            Destroy(gameObject);
            
        }
    }


private void Update(){
if(attackSpeed <= canAttack){
            GetComponent<FriendHealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;
        } else{
                canAttack += Time.deltaTime;
            }}
}
