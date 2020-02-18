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

	private void Start() {
		IsThereHole = false;
	}

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * speed;

		if(Input.GetKeyDown("space") && !IsThereHole)
		{
			//Debug.Log(HoleSpawner.position);
			Instantiate(holePrefab, this.transform.position, Quaternion.identity);
			IsThereHole = true;
		}
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}
}
