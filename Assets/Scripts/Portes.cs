using UnityEngine;
using System.Collections;

public class Portes : MonoBehaviour {

	public float smooth = 20F;
	public float tiltAngle = 35.0F;

	private float door;

	public bool canOpen = true;

	void Start () {}
	
	void Update() {

		if(canOpen == true){

			door = map (Input.GetAxis ("Horizontal"), -1, 0, 0, -1);

			float tiltAroundY = door * tiltAngle;

			Debug.Log (Input.GetAxis ("Horizontal"));

			Quaternion target = Quaternion.Euler(0, tiltAroundY * 3.2f, 0);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		}

		if (canOpen == false && transform.rotation.y > 0.08) {
			Quaternion target = Quaternion.Euler (0, 0, 0);
			transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * smooth);
		} else if (canOpen == false && transform.rotation.y < 0.08) {
			Quaternion target = Quaternion.Euler (0, 0, 0);
			transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * smooth);
		}
	}

	float map(float s, float a1, float a2, float b1, float b2){

		return b1 + (s-a1)*(b2-b1)/(a2-a1);
	}
}
