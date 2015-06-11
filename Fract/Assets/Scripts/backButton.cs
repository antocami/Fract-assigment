using UnityEngine;
using System.Collections;

public class backButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		Application.LoadLevel ("menu");
	}
}
