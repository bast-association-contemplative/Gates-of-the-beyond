using UnityEngine;
using System.Collections;

public class randomDoor : MonoBehaviour {

	public GameObject porteGauche1;
	public GameObject porteDroite1;

	public GameObject porteGauche2;
	public GameObject porteDroite2;

	private int openDoor;

	void Start () {}
	
	void Update () {
		
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {

			openDoor = Random.Range (0, 2);

			if (openDoor == 0) {
				porteDroite1.GetComponent<Portes> ().canOpen = false;
				porteGauche1.GetComponent<Portes> ().canOpen = false;

				porteDroite2.GetComponent<Portes> ().canOpen = true;
				porteGauche2.GetComponent<Portes> ().canOpen = true;

			} else if (openDoor == 1) {
				porteDroite1.GetComponent<Portes> ().canOpen = true;
				porteGauche1.GetComponent<Portes> ().canOpen = true;

				porteDroite2.GetComponent<Portes> ().canOpen = false;
				porteGauche2.GetComponent<Portes> ().canOpen = false;
			}
		}
	}
}
