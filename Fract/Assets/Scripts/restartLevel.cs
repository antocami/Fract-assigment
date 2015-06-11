using UnityEngine;
using System.Collections;

public class restartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown()
	{
		Application.LoadLevel (Application.loadedLevelName);
		
	}




	
	// Update is called once per frame
	void Update () {
		


}
}
