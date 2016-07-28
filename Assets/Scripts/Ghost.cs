using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {

	private float m_Rnd;

	public Rigidbody projectile;
	public Transform shotPos;
	private Vector3 pos;
	public float shotForce = 1000f;

	public float fireRate = 1.0f;
	//private float lastShot = 0.0f;

	void Start () {
		m_Rnd = Random.value*100;
		pos = transform.position;
	}
	
	void Update () {
		if (Input.GetAxis ("Horizontal") < -0.5) {

			//if (Time.time > fireRate + lastShot) {
			
				float x = Mathf.PerlinNoise (m_Rnd + 0 + Time.time * 2, m_Rnd + 1 + Time.time * 2) - 0.5f;
				float y = Mathf.PerlinNoise (m_Rnd + 2 + Time.time * 2, m_Rnd + 3 + Time.time * 2) - 0.5f;
				float z = Mathf.PerlinNoise (m_Rnd + 4 + Time.time * 2, m_Rnd + 5 + Time.time * 2) - 0.5f;
				transform.localPosition = Vector3.up + new Vector3 (x + pos.x, y + pos.y, z + pos.z) * 1;

				Quaternion target = Quaternion.Euler (x, y, z);
				transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime);


				Rigidbody shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as Rigidbody;
				shot.AddForce (shotPos.forward * shotForce);

				//lastShot = Time.time;
			//}
		}
	}
}
