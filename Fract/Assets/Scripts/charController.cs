using UnityEngine;
using System.Collections;

public class charController : MonoBehaviour
{
	public float hoverForce = 75.0f;
	public Transform groundCheckTransform;
	public ParticleSystem hover;
	public float forwardSpeed = 3.0f;
	private bool death = false;
	private uint coin = 0;
	private  bool pause = false;
	public AudioClip coinSound;
	public AudioClip deathsound;
	public AudioClip mayDay;
	public AudioClip speedUP;
	public AudioClip speedDown;
	public Texture2D coinIconTexture;



	private bool grounded;

	public LayerMask groundCheckLayerMask;

	Animator animator;
	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{
		bool hoverActive = Input.GetButton ("Fire1");

		hoverActive = hoverActive && !death;

		if (hoverActive) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, hoverForce));
		}

		if (!death) {

			Vector2 newSpeed = GetComponent<Rigidbody2D> ().velocity;
			newSpeed.x = forwardSpeed;
			GetComponent<Rigidbody2D> ().velocity = newSpeed;
		}

		UpdateGroundedStatus ();
		AdjustHover (hoverActive);

	
	}

	void UpdateGroundedStatus ()
	{
		
		grounded = Physics2D.OverlapCircle (groundCheckTransform.position, 0.1f, groundCheckLayerMask);


		animator.SetBool ("grounded", grounded);
	}

	void AdjustHover (bool hoverActive)
	{
		hover.enableEmission = !grounded;
		hover.emissionRate = hoverActive ? 300.0f : 75.0f; 
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		
		{
			if (collider.gameObject.CompareTag ("coin"))
				CoinGet (collider);
			else if (collider.gameObject.CompareTag ("speedup"))
				SpeedGet (collider);
			else if (collider.gameObject.CompareTag ("slowdown"))
				SlowGet (collider);
			else
				HitbyBlock (collider);
			
		}

	}



	void HitbyBlock (Collider2D blockCollider)
	{
		death = true;

		animator.SetBool ("dead", true);
		AudioSource.PlayClipAtPoint (mayDay, transform.position);
	}

	void CoinGet (Collider2D coinCollider)
	{
		coin++;

		Destroy (coinCollider.gameObject);
		AudioSource.PlayClipAtPoint (coinSound, transform.position);

			        
	}

	void SpeedGet (Collider2D speedCollider)
	{
		forwardSpeed += 10;
		Destroy (speedCollider.gameObject);
		AudioSource.PlayClipAtPoint (speedUP, transform.position);
	}

	void SlowGet (Collider2D speedCollider)
	{
		forwardSpeed -= 2;
		Destroy (speedCollider.gameObject);
		AudioSource.PlayClipAtPoint (speedDown, transform.position);
	}


	void DisplayCoinsCount ()
	{
		Rect coinIconRect = new Rect (60, 60, 32, 32);
		GUI.DrawTexture (coinIconRect, coinIconTexture);                         

		GUIStyle style = new GUIStyle ();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.white;

		Rect labelRect = new Rect (coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label (labelRect, coin.ToString (), style);
	}

	void OnGUI ()
	{
		DisplayCoinsCount ();
		DisplayRestartButton ();
		DisplayWin();
		//Coroutine();
	}

	void DisplayRestartButton ()
	{
		if (death && grounded) {

			GameObject.FindGameObjectWithTag("mybtn").GetComponent<Renderer>().enabled = true;
			GameObject.FindGameObjectWithTag("mybtn").GetComponent<BoxCollider2D>().enabled = true;

                        
          
		}
	}

	void DisplayWin()
	{
		 if (coin >= 200) {


 		
				
				Application.LoadLevel ("menu");
				

			}
		}
		
		
}


