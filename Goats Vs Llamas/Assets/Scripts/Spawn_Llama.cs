using UnityEngine;
using System.Collections;

public class Spawn_Llama : MonoBehaviour {
	public GameObject llama;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			Instantiate(llama, transform.position, transform.rotation);
		}
	}
}
