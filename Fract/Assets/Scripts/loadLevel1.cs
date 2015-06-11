using UnityEngine;
using System.Collections;

public class loadLevel1 : MonoBehaviour {

	public AudioClip selectSound;

	// Use this for initialization
	void Start () {

	}


	void Update () {

	}
	void OnMouseDown(){
		
		Application.LoadLevel ("Level 1");
		AudioSource.PlayClipAtPoint (selectSound, transform.position);


	} 



}
