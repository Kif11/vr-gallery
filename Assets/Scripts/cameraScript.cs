using UnityEngine;
using System.Collections;
//using VRStandardAssets.Utils;

public class cameraScript : MonoBehaviour {

//	public event Action OnDoubleClick;      // Called when double click input is detected whilst the gaze is over this object.

	int tapCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown ("space") || Input.GetMouseButtonDown (0)) {
//			RaycastHit hit;
//			Vector3 fwd = transform.TransformDirection (Vector3.forward);
//			if (Physics.Raycast (transform.position, fwd, out hit)) {
//				hit.transform.SendMessage ("HitByRay");
//				tapCount = 0;
//			}
//		}
			if (tapCount == 0) {
				gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 9);
				tapCount = tapCount + 1;
			}
			else if (tapCount == 1) {
				RaycastHit hit;
				Vector3 fwd = transform.TransformDirection (Vector3.forward);
				if (Physics.Raycast (transform.position, fwd, out hit)) {
					hit.transform.SendMessage ("HitByRay");
					tapCount = 0;
				}
				
			}
		}
	
	}
}
