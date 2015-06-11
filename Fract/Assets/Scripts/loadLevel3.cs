using UnityEngine;
using System.Collections;

public class loadLevel3 : MonoBehaviour {
	public AudioClip selectSound;
	// Use this for initialization
	void Start () {
	
	}


	void Update () {

	}
	void OnMouseDown(){
		
		Application.LoadLevel ("Level 3");
		AudioSource.PlayClipAtPoint (selectSound, transform.position);
	} 



}
