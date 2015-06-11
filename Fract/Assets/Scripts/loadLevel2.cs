using UnityEngine;
using System.Collections;

public class loadLevel2 : MonoBehaviour {
	public AudioClip selectSound;
	// Use this for initialization
	void Start () {
	
	}


	void Update () {

	}
	void OnMouseDown(){
		
		Application.LoadLevel ("Level 2");
		AudioSource.PlayClipAtPoint (selectSound, transform.position);
	} 



}
