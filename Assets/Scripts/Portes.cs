using UnityEngine;
using System.Collections;

public class Portes : MonoBehaviour {

	public GameObject ghost;
	public Transform shotPos;

	public float smooth = 20F;
	public float tiltAngle = 35.0F;

	private bool canShoot = true;

	void Start () {
	
	}
	
	void Update() {
		float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
		Quaternion target = Quaternion.Euler(0, tiltAroundY * 3.2f, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

		if (transform.rotation.y > 0.5 && canShoot == true) {
			//Debug.Log ("GO");
			Instantiate (ghost, shotPos.position, ghost.transform.rotation);
			canShoot = false;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			canShoot = true;
		}
	}
}
