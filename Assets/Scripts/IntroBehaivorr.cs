using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBehaivorr : StateMachineBehaviour
{
    private int rand;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        rand = Random.Range(0, 1);

        if (rand == 0)
        {
            animator.SetTrigger("Run");
            Debug.Log("Idol");
        }
        else {
            animator.SetTrigger("Idol");
            Debug.Log("RUN");
        }
	}
    
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
    }

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

}
   

