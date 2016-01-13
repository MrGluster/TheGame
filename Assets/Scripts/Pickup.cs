﻿using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		//Pickup??
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		RaycastHit hit;
		if (Input.GetButtonDown ("Pickup")) {
			if (Physics.Raycast(transform.position, fwd, out hit, 1)) 
			{
				hit.collider.transform.parent = transform.parent; 
				Destroy (hit.collider.attachedRigidbody);
			
			//print("Akta, krock på gång!");
			}
		}
		//print("space key was pressed");
		//Physics.Raycast(transform.position, transform.forward, hit
		//Debug.DrawRay(transform.position, forward, Color.green);

		//skjuta ut en ray mot lådan, kolla hur nära lådan är,
		//om lådan är tillräckligt nära lyft upp den(Ta bort en komponent, och lägga till en, för att sedan lägga till den första igen,),
		//lyfta upp = lådan hamnar under forklift_tray eller forklift_tray_traystart med den som parent, ta bort komponent Rigidbody
		//släpp = lådan blir vuxen (fristående), och Rigidbody läggs tillbaka på lådan igen, helst med samma egenskaper som innan.
	}
}

