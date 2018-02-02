using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanger : MonoBehaviour {


	public bool ugandan = false; //Used in CheatCodes.cs

	[SerializeField]
	private GameObject _model1; 
	[SerializeField]
	private GameObject _model2;

	private GameObject _currentModel;

	void Start()
	{
		_currentModel = Instantiate(_model1, transform.position, transform.rotation) as GameObject; 
		_currentModel.transform.parent = transform; 
	}

	public void ChangeModel(){
		if (!ugandan) {
			GameObject thisModel = Instantiate(_model2, transform.position, transform.rotation) as GameObject;  
			Destroy(_currentModel);
			thisModel.transform.parent = transform; 
			_currentModel = thisModel; 
			ugandan = true;
		}
		else if(ugandan){
			GameObject thisModel = Instantiate(_model1, transform.position, transform.rotation) as GameObject; 
			Destroy(_currentModel); 
			thisModel.transform.parent = transform; 
			_currentModel = thisModel; 
			ugandan = false;
		} 
	}
}
