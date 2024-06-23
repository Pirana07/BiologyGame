using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eritrocyteFriendD : MonoBehaviour
{
    public TMP_Text MyscoreText;
 
    private int ScoreNumber;

    public GameObject Particle;

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
            Destroy(Coin.gameObject);//destroy when the Worker touches the coin
            MyscoreText.text = "Score: " + ScoreNumber;
        }
            
         
    }



}
