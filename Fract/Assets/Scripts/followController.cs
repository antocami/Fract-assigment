using UnityEngine;
using System.Collections;

public class followController : MonoBehaviour {
	public GameObject followObject;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float followObjectX = followObject.transform.position.x;
		Vector3 newCamPos = transform.position;
		newCamPos.x = followObjectX;
		transform.position = newCamPos;


	
	}
}
