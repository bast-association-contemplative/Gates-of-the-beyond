using UnityEngine;
using System.Collections;

public class movieTexture : MonoBehaviour {

	private new Renderer renderer;
	public MovieTexture[] movTexture;
	private int RandomGhost = 0;

	void Start() {
		renderer = GetComponent<Renderer> ();

		RandomGhost = Random.Range (0, movTexture.Length);

		renderer.material.mainTexture = movTexture[RandomGhost];

		movTexture[RandomGhost].Stop();
		movTexture[RandomGhost].Play();
	}

	/*void Update(){
		if (movTexture.isPlaying) {
			movTexture[RandomGhost].Stop();
		}
	}*/
}