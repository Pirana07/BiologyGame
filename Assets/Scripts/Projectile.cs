using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public float speed;

    [SerializeField] private float attackDamage = 20f;
    private Transform player;
    private Vector2 target;

    void Start() {

        player = GameObject.FindGameObjectWithTag("Player").transform;

            target = new Vector2(player.position.x, player.position.y);
    }


    void Update() {

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y) {
            DestroyProjectile();
        }
    }


     private void OnCollisionEnter2D (Collision2D other){
        if(other.gameObject.tag == "Player"){
            DestroyProjectile();
            other.gameObject.GetComponent<Playerhealth>().UpdateHealth(-attackDamage);
        }
    }

    private void OnCollisionStay2D (Collision2D other){
        if(other.gameObject.tag == "Player"){
             DestroyProjectile();
            other.gameObject.GetComponent<Playerhealth>().UpdateHealth(-attackDamage);
        }
    }


    void DestroyProjectile() {

        Destroy(gameObject);
    }
}
