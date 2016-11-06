using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")) {
			Debug.Log ("pressed button");

			RaycastHit hit;
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			if (Physics.Raycast(transform.position, fwd, out hit))
			   	hit.transform.SendMessage ("HitByRay");
			
	}
	
	}
}
