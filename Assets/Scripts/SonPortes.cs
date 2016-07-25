using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class SonPortes : MonoBehaviour {

	private AudioSource audio;
	public AudioClip[] doors;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") < -0.5) {
			
				if (!audio.isPlaying) {
					audio.clip = doors [0];
					audio.Play ();
				}


		}
	}
}
