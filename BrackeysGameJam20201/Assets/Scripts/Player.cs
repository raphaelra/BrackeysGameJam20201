using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

	public float speed = 4f;
	public Rigidbody2D rb;
	public GameObject holePrefab;
	private float movement = 0f;
	public static bool IsThereHole;
	private GameObject hole;
	public float HoleOffset = 0.5f;


	private Vector3 PlayerFeet;

	private void Start() {
		IsThereHole = false;
		PlayerFeet = this.transform.position - new Vector3(0f,HoleOffset,0f);
	}

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * speed;

		if(Input.GetKeyDown("space") && !IsThereHole)
		{
			PlayerFeet = this.transform.position - new Vector3(0f,HoleOffset,0f);
			//Debug.Log(HoleSpawner.position);
			Instantiate(holePrefab, PlayerFeet, Quaternion.identity);
			IsThereHole = true;
		}
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}
}
