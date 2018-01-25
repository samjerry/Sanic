using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatCodes : MonoBehaviour {

	public GameObject Cmd;

	public ModelChanger MC;

	public Timer timer;

	private string _pInput;
	private string _cInput;

	public void Start(){
		_pInput = Cmd.GetComponent<InputField>().text;
		Cmd.SetActive(false);
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.BackQuote) || Input.GetKeyDown (KeyCode.Escape)) {
			if (!Cmd.activeInHierarchy) {
				Cmd.SetActive (true);
			} else {
				Cmd.SetActive (false);
			}
		}
		if (Cmd.activeInHierarchy) {
			ConsoleChecker ();
		}
	}

	public void ConsoleChecker(){
		Debug.Log ("checking console");
		_pInput = Cmd.GetComponent<InputField>().text;
		if (Input.GetKeyDown (KeyCode.Return)) {
			_cInput = _pInput;
			Debug.Log (_pInput);
			if (_cInput == "doyouknowdatime?") {
				timer.Mil = 0; 
				timer.Sec = 0;
				timer.Min = 0; 
				Debug.Log ("time is 0");
			} else if (_cInput == "ugandanstyle") {
				MC.ChangeModel ();
			} else if (_cInput == "") {
				//pHealth.playerHP = Mathf.Infinity;
			}  else {
				//change player's position to start
			}
		}
	}
}

//else if (_cInput == "partytime" && !isMoving) {
//	if (MC.ugandan) {
//		play ugandan knuckels animation (dance)
//	}else{
//		play normal knuckles animation (dance)
//	}
//}