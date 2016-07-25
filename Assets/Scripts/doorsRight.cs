using UnityEngine;
using System.Collections;

public class doorsRight : MonoBehaviour {

	Animator doorsAnim;

	void Start () {
		doorsAnim = GetComponent<Animator>();
	}
	
	void Update () {


		if (Input.GetKey ("p")) {

			doorsAnim.SetTrigger ("open");

		} else if (Input.GetKey ("c")) {
		
			doorsAnim.SetTrigger ("close");
		
		}
	}
}
