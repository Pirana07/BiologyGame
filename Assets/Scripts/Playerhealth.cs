using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
   public int Respawn;
   private float health = 0f;
   [SerializeField] private float maxHealth = 100f;
   [SerializeField] private Slider healthSlider;
   [SerializeField] private float attackDamage = 5f;
   [SerializeField] private float attackSpeed = 2f;
    private float canAttack;



   private void Start(){
    health = maxHealth;
    healthSlider.maxValue = maxHealth;

   }

    public void UpdateHealth(float mod){
        health += mod;

        if(health > maxHealth){
            health = maxHealth;
        } else if(health <= 0f){
            health = 0f;
            healthSlider.value = health;
            Destroy(gameObject);
            LevelManager.manager.GameOver();

            
        }
    }
private void OnGUI(){
    healthSlider.value = health;
}

private void Update(){
if(attackSpeed <= canAttack){
            GetComponent<Playerhealth>().UpdateHealth(-attackDamage);
            canAttack = 0f;
        } else{
                canAttack += Time.deltaTime;
            }}
}
