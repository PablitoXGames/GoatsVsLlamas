using UnityEngine;
using System.Collections;

public class Movement_2D : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (movex * Speed, 3*movey * Speed);
	}

}
