using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	private float _score = 0;

	private Text _scoreText;

	public void ScoreUpdate(){
		Debug.Log ("updating score");
		_score++;
		_scoreText.text = string.Format("{0:00}", _score);
	}
}
