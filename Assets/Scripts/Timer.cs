using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float Mil;
	public float Sec;	//Used in CheatCodes.cs
	public float Min;

	private float _timerSpd;

	private string _displayTimer;

	[SerializeField]
	private Text _timerText;

	public void Start(){
		_timerSpd = Time.deltaTime * 100;
	}

	public void Update(){
		if (Time.timeScale == 1) {
			TimerUpdate ();
		}
		_timerText.text = _displayTimer;
	}

	public void TimerUpdate(){

		Mil += 1 * _timerSpd;

		if (Mil == 100) {
			Sec += 1;
			Mil = 0;
		}

		if (Sec == 60) {
			Min += 1;
			Sec = 0;
		}

		_displayTimer = string.Format("{0:00}:{1:00}.{2:00}", Min, Sec, Mil);
	}
}