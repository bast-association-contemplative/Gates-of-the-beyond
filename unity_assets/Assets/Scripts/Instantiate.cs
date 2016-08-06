using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject ghost;
	public Transform shotPos;

	private bool canShoot = true;

	void Start () {}
	
	void Update () {
		if (transform.rotation.y > 0.5 && canShoot == true) {
			Instantiate (ghost, shotPos.position, ghost.transform.rotation);
			canShoot = false;
		}

		if (transform.rotation.y < 0.1) {
			canShoot = true;
		}
	}
}
