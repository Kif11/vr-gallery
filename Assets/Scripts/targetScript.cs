using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class targetScript : MonoBehaviour {

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");
		SceneManager.LoadScene ("cubeScene");
	}
}
