using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public TMP_Text Score;
   public GameObject UWin;
   public GameObject Boss;

   public void Restart(){
    SceneManager.LoadScene(0);
   }

      void Update()
    {
        if(Score.text == "Score: 50"){
         UWin.SetActive(true);
         Boss.SetActive(false);
        }
    }
}
