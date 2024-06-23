using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

public static SoundManager sndMan;
private AudioSource audioSrc;
private AudioClip[] coinSounds;

private int randomCoinSound;


    void Start()
    {
        sndMan = this;
        audioSrc = GetComponent<AudioSource>();
        coinSounds = Resources.LoadAll<AudioClip>("CoinSounds");
    
    }

    public void PlayCoinSound(){
      
      randomCoinSound = Random.Range(0,1);
      audioSrc.PlayOneShot(coinSounds[randomCoinSound]);

    }

}
