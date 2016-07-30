using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class SonPortes : MonoBehaviour {

	private new AudioSource audio;
	public AudioClip[] doors;

	void Start () {
		audio = GetComponent<AudioSource> ();	
	}

	void Update () {
		if (Input.GetAxis ("Horizontal") < -0.5) {
			if (!audio.isPlaying) {
				audio.clip = doors [0];
				audio.Play ();
			}
		}
	}
}
