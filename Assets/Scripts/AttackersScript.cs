using UnityEngine;
using System.Collections;

public class AttackersScript : MonoBehaviour {


	[Range(-1.5f,1.0f)] public float walkSpeed;
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D> ();
		myRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}
}
