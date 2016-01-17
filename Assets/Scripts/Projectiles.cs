using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {

	public float damage;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.right*speed*Time.deltaTime);
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		AttackersScript attacker = collider.gameObject.GetComponent<AttackersScript>();
		Health health = collider.gameObject.GetComponent<Health>();

		if (attacker && health) {
			health.DealDamage(damage);
			Destroy(gameObject);
		}

	}

}
