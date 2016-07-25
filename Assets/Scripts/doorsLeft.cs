using UnityEngine;
using System.Collections;

public class doorsLeft : MonoBehaviour {

	Animator doorsAnim;

	void Start () {
		doorsAnim = GetComponent<Animator>();
	}
	
	void Update () {


		if (Input.GetKey ("q")) {

			doorsAnim.SetTrigger ("open");

		} else if (Input.GetKey ("s")) {
		
			doorsAnim.SetTrigger ("close");
		
		}
	}
}
