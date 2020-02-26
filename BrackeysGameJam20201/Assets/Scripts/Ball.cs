using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour {

	private Vector2 startForce;
	public Rigidbody2D rb;

	public float MinXForce = 5;
	public float MaxXForce = 11;
	public float MinYForce = 8;
	public float MaxyForce = 18;

	// Use this for initialization
	void Start () 
	{
		startForce = new Vector2(Random.Range(-MaxXForce, -MinXForce), Random.Range(MinYForce, MaxyForce));
		rb.AddForce(startForce, ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Player")
		{
			Manager.LoseLife();
		}
	}


	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.GetComponent<Collider2D>().tag == "Hole")
		{
			//Debug.Log("GAME OVER!");
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Manager.BallsToSpawn--;
			       // Debug.Log(Manager.BallsToSpawn);

			Destroy(this.gameObject);
		}
	}

}


