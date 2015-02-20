using UnityEngine;
using System.Collections;

public class Right_Spawn : MonoBehaviour {
	public GameObject goat;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Q)) {
			Instantiate(goat, transform.position, transform.rotation);
		}
	
	}
}
