using UnityEngine;
using System.Collections;

public class FoxScript : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	AttackersScript attacker;
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		attacker = gameObject.GetComponent<AttackersScript>();
	}
	
	void OnTriggerEnter2D(Collider2D collider ){
		if (collider.gameObject.GetComponent<Defenders> ()) {
			
			if(collider.gameObject.GetComponent<Stone>())
			{
				anim.SetTrigger("jumpTrigger");
				return;
			}
			anim.SetBool("isAttacking",true);
			attacker.setCurrentTarget(collider.gameObject);
		
		}
		
	}
}
