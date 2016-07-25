using UnityEngine;
using System.Collections;

public class Portes : MonoBehaviour {

	public float smooth = 20F;
	public float tiltAngle = 35.0F;

	void Start () {
	
	}
	
	void Update() {
		float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
		Quaternion target = Quaternion.Euler(0, tiltAroundY * 3.2f, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}
}
