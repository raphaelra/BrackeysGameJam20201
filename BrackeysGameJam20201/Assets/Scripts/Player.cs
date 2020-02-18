using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

	public float speed = 4f;
	public Rigidbody2D rb;

	private float movement = 0f;
	public bool IsThereHole;



	private void Start() {
		IsThereHole = false;
	}

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * speed;
	
	if(IsThereHole && Input.GetKeyDown("space"))
	{
		print("space");
	}

	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}
}
