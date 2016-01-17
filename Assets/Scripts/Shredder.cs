using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider ){
		//destroying the game object which collides with the shredder
		Destroy (collider.gameObject);	
	}
}
