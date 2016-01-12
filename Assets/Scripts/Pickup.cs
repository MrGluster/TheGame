using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Pickup??
		if (Input.GetButtonDown ("Pickup")) {
			Vector3 fwd = transform.TransformDirection (Vector3.forward);

			if (Physics.Raycast(transform.position, fwd, 10)) {
				print("There is something in front of the object!");

			}}
		//print("space key was pressed");
		//Physics.Raycast(transform.position, transform.forward, hit
		//Debug.DrawRay(transform.position, forward, Color.green);

		//skjuta ut en ray mot lådan, kolla hur nära lådan är,
		//om lådan är tillräckligt nära lyft upp den(Ta bort en komponent, och lägga till en, för att sedan lägga till den första igen,), 
	}
}

