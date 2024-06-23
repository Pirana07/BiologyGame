using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class erythrocyte : MonoBehaviour
{
     public TMP_Text MyscoreText;
 
    private int ScoreNumber;

    public GameObject Particle;

   [SerializeField] private float healDamage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
        MyscoreText.text = "Score: " + ScoreNumber;
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "MyCoin")
        {
            ScoreNumber++;
            Instantiate(Particle, Coin.transform.position,  Quaternion.identity);
            Destroy(Coin.gameObject);//destroy when the player touches the coin
            SoundManager.sndMan.PlayCoinSound();
            MyscoreText.text = "Score: " + ScoreNumber;
            GetComponent<Playerhealth>().UpdateHealth(+healDamage);
        }
            
         
    }




            
    }



