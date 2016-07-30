using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class movieTexture : MonoBehaviour {

	public AudioClip[] ghostSound;
	new AudioSource audio;

	private new Renderer renderer;
	public MovieTexture[] movTexture;
	private int RandomGhost = 0;

	void Start() {
		renderer = GetComponent<Renderer> ();

		RandomGhost = Random.Range (0, movTexture.Length);

		renderer.material.mainTexture = movTexture[RandomGhost];

		movTexture[RandomGhost].Stop();
		movTexture[RandomGhost].Play();

		audio = GetComponent<AudioSource>();

		audio.clip = ghostSound[Random.Range(0, ghostSound.Length)];
		audio.Play();
	}
}