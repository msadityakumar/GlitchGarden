using UnityEngine;
using System.Collections;

public class AttackersScript : MonoBehaviour {

	GameObject currentTarget;
	[Range(-1.5f,1.0f)] public float walkSpeed;

	Animator anim;
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D> ();
		myRigidBody.isKinematic = true;
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}



	public void setWalkSpeed(float speed)
	{
		walkSpeed = speed;
	}

	public void StrikeCurrentTarget (float damage)
	{
		Health healthComponent = currentTarget.GetComponent<Health> ();
		if (healthComponent) {
			Debug.Log ("health component decreasing");
		bool status = healthComponent.DealDamage (damage);
			if(status)
			{
				Debug.Log("stone dead");
				anim.SetBool("isAttacking",false);
			}
		} 
	}

	public void setCurrentTarget(GameObject obj)
	{
		currentTarget = obj;
	}
}
