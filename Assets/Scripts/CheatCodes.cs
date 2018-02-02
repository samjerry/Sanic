using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatCodes : MonoBehaviour {

	[SerializeField]
	private GameObject _cmd;
	[SerializeField]
	private GameObject _player;
	[SerializeField]
	private GameObject _spawn;

	[SerializeField]
	private ModelChanger _mC;

	[SerializeField]
	private Timer _timer;

	private string _pInput;
	private string _cInput;

	public void Start(){
		_pInput = _cmd.GetComponent<InputField>().text;
		_cmd.SetActive(false);
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.BackQuote) || Input.GetKeyDown (KeyCode.Escape)) {
			if (!_cmd.activeInHierarchy) {
				_cmd.SetActive (true);
			} else {
				_cmd.SetActive (false);
			}
		}
		if (_cmd.activeInHierarchy) {
			ConsoleChecker ();
		}
	}

	public void ConsoleChecker(){
		Debug.Log ("checking console");
		_pInput = _cmd.GetComponent<InputField> ().text;
		if (Input.GetKeyDown (KeyCode.Return)) {
			_cInput = _pInput;
			Debug.Log (_pInput);
			if (_cInput == "doyouknowdatime?") {
				_timer.Mil = 0; 
				_timer.Sec = 0;
				_timer.Min = 0; 
				Debug.Log ("time is 0");
			} else if (_cInput == "ugandanstyle") {
				_mC.ChangeModel ();
			} else if (_cInput == "knucklelivesmatter") {
				Debug.Log ("life is infinite");
				//pHealth.playerHP = Mathf.Infinity;
			} else {
				//change player's position to start
				_player.transform.position = _spawn.transform.position;
				_player.transform.rotation = _spawn.transform.rotation;
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