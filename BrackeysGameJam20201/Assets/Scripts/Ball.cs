using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour {

	public Vector2 startForce;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb.AddForce(startForce, ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Player")
		{
			//Debug.Log("GAME OVER!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}


	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.GetComponent<Collider2D>().tag == "Hole")
		{
			//Debug.Log("GAME OVER!");
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Destroy(this.gameObject);
		}
	}
}


