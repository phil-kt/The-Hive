using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col) {
		if (col.transform.tag == "Player"){
 			Application.LoadLevel(Application.loadedLevel);
		}
		print("hit");
	 }
}
