using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody _rigidbody;
	private Vector3 _inputDirection;

	[SerializeField]
	private float Player_speed = 7;
	private float _moveH;
	private float _moveV;

	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		_moveH = Input.GetAxis("Horizontal");
		_moveV = Input.GetAxis("Vertical");

		_inputDirection = new Vector3 (_moveH, 0f, _moveV);

		if (Input.GetKeyDown ("space")){
			transform.Translate(Vector3.up * 260 * Time.deltaTime);
		} 
	} 

	void FixedUpdate(){
		_rigidbody.AddForce (_inputDirection * Player_speed);
	}
}