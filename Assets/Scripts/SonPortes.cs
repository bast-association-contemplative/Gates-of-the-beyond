using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class SonPortes : MonoBehaviour {

	private new AudioSource audio;
	public AudioClip[] doors;

	private bool canPlay = true;
	private bool canPlayClose = false;

	void Start () {
		audio = GetComponent<AudioSource> ();	
	}

	void Update () {
		if (transform.rotation.y > 0.005 && canPlay == true) {
			if (!audio.isPlaying) {
				audio.clip = doors [0];
				audio.Play ();

				canPlay = false;
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow) && transform.rotation.y > 0.4) {
			audio.clip = doors [1];
			audio.Play ();
		}

		if (transform.rotation.y < 0.3) {
			canPlay = true;
		}
	}
}
