using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour {

	public Vector2 startForce;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		startForce = new Vector2(Random.Range(-2f, 2f), Random.Range(2.0f, 2.0f));
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
			//Manager.BallsToSpawn--;
			       // Debug.Log(Manager.BallsToSpawn);

			Destroy(this.gameObject);
		}
	}

}


