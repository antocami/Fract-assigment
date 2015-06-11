using UnityEngine;
using System.Collections;

public class loadLevel4 : MonoBehaviour {
	public AudioClip selectSound;
	// Use this for initialization
	void Start () {
	
	}


	void Update () {

	}
	void OnMouseDown(){
		
		Application.LoadLevel ("Level 4");
		AudioSource.PlayClipAtPoint (selectSound, transform.position);
	} 



}
