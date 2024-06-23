using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class New_scene : MonoBehaviour
{
    public TMP_Text Score;
    

    // Update is called once per frame
    void Update()
    {
        if(Score.text == "Score: 20"){
        SceneManager.LoadScene("BossFight");
        }
    }
}
