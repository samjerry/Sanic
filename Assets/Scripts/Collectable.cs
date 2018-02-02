using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	private ScoreCounter _count;

	void start(){
		_count = GetComponent<ScoreCounter>();
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("touched something");
	if (other.gameObject.CompareTag ("Player")){
		Debug.Log ("touched player");
		this.gameObject.SetActive (false);
			_count.ScoreUpdate ();
		}
	}
}