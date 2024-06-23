using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeathboss : MonoBehaviour
{
    
    private bool Death = false;
 
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obsticle"))
        {
       
           
                Death = true;
            
        }
    }
        
    void Update(){
        if(Death == true){
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   
}

