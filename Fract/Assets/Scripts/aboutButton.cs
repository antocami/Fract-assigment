using UnityEngine;
using System.Collections;

public class aboutButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		Application.LoadLevel ("about");
	}
}
