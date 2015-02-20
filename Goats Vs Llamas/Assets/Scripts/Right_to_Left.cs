using UnityEngine;
using System.Collections;

public class Right_to_Left : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movex = 1f;
		movey = 1f;
		rigidbody2D.velocity = new Vector2 (-movex * Speed, 0);
	}
}
