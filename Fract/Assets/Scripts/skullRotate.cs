﻿using UnityEngine;
using System.Collections;

public class skullRotate : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	


}
	
	// Update is called once per frame
	
void Update () {


transform.Rotate(1, Time.deltaTime, 0, Space.World);
	
	}

}
