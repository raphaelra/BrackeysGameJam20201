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
    public float mobilespeed = 20f;


	private Vector3 PlayerFeet;

	private void Start() {
		IsThereHole = false;
		PlayerFeet = this.transform.position - new Vector3(0f,HoleOffset,0f);
	}

	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown("space"))
		{
			PlayerFeet = this.transform.position - new Vector3(0f,HoleOffset,0f);
			//Debug.Log(HoleSpawner.position);
			Instantiate(holePrefab, PlayerFeet, Quaternion.identity);
			//IsThereHole = true;
		}

		 if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    //Debug.Log("no touchy");
					PlayerFeet = this.transform.position - new Vector3(0f,HoleOffset,0f);
					Instantiate(holePrefab, PlayerFeet, Quaternion.identity);
					//IsThereHole = true;
                    break;

                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    break;
            }
        }
	}

	void FixedUpdate ()
	{
		movement = Input.GetAxis("Horizontal") * speed;
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));

		Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        //dir.z = Input.acceleration.x;

         if (dir.sqrMagnitude > 1)
            {dir.Normalize();}
        dir *= Time.deltaTime;
        transform.Translate(dir * mobilespeed);
	}
}
