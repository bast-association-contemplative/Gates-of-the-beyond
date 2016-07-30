using UnityEngine;
using System.Collections;

public class Portes : MonoBehaviour {

	public float smooth = 20F;
	public float tiltAngle = 35.0F;

	//private float doorsTest = 0;

	void Start () {}
	
	void Update() {

		//Debug.Log (Input.GetAxis ("Horizontal"));

		/*while(doorsTest >= -1){

			float tiltAroundY = doorsTest * tiltAngle;
			Quaternion target = Quaternion.Euler(0, tiltAroundY * 3.2f, 0);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

			doorsTest = doorsTest - 0.1f;
		}*/

		float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
		Quaternion target = Quaternion.Euler(0, tiltAroundY * 3.2f, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}
}
