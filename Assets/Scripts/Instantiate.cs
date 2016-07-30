using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject ghost;
	public Transform shotPos;

	private bool canShoot = true;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.rotation.y > 0.5 && canShoot == true) {
			Instantiate (ghost, shotPos.position, ghost.transform.rotation);
			canShoot = false;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			canShoot = true;
		}
	}
}
