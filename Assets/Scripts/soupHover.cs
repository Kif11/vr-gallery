using UnityEngine;
using System.Collections;
using System;

public class soupHover : MonoBehaviour {
	float i = 0.0f;
	private float rad1=0.04f;
	private float rad2=0.06f;
	private float cx, cy, cz, id;
	// Use this for initialization
	void Start () {
		cx=transform.position.x;
		cz=transform.position.z;
		cy=transform.position.y;
		System.Random randomNumber = new System.Random(GetInstanceID());
		float f = UnityEngine.Random.Range (0.0f, 2.0f);
		if (f > 1) {
			rad2 = rad2 * -1;
			rad1 = rad1 * -1;
		}


	}


	// Update is called once per frame
	void Update () {
		float x = cx + (float)Math.Sin(Time.time)*rad1; 
		float y = cy + (float)Math.Cos(Time.time)*rad2;
		transform.position=new Vector3(x, y, transform.position.z);
	}
}
