using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100.0f;
	public bool DealDamage(float damage)
	{
		health -= damage;

		if (health <= 0.0f) 
		{
		//the defender is dead 
			Destroy(gameObject);
			return true;
		}
		return false;
	}
}
