using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile ,projectileParent;
	// Use this for initialization
	void Start () {
	}
	
	private void Fire()
	{
	
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gameObject.transform.position;


	}
}
