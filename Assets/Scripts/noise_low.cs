using UnityEngine;
using System.Collections;

public class noise_low : MonoBehaviour {

	private float m_Rnd;
	private Vector3 pos;

	void Start () {
		m_Rnd = Random.value*100;
		pos = transform.position;
	}
	
	void Update () {
		float x = Mathf.PerlinNoise (m_Rnd + 0 + Time.time, m_Rnd + 1 + Time.time) /2 - 0.5f;
		float y = Mathf.PerlinNoise (m_Rnd + 2 + Time.time, m_Rnd + 3 + Time.time) /2 - 0.5f;
		float z = Mathf.PerlinNoise (m_Rnd + 4 + Time.time, m_Rnd + 5 + Time.time) /2 - 0.5f;
		transform.localPosition = Vector3.up + new Vector3 (x + pos.x, y + pos.y, z + pos.z) * 1;
	}
}
