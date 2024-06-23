using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2 : MonoBehaviour
{

public static SoundManager2 sndMan2;
private AudioSource audioSrc;
private AudioClip[] coinSounds;

private int randomCoinSound;


    void Start()
    {
        sndMan2 = this;
        audioSrc = GetComponent<AudioSource>();
        coinSounds = Resources.LoadAll<AudioClip>("Hit");
    
    }

    public void PlayCoinSound(){
      
      randomCoinSound = Random.Range(0,1);
      audioSrc.PlayOneShot(coinSounds[randomCoinSound]);

    }

}

