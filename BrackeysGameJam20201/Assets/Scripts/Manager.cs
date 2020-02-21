using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static int BallsToSpawn;
    public static int Level = 1;
    private int LiveBalls;
    public GameObject BallPrefabs;
    public Transform SpawnPoint;
    public Text LevelText;


    // Start is called before the first frame update
    void Start()
    {
        LevelText.text = "Level: " + Level; 
        StartLevel();
    }
    // Update is called once per frame

    void StartLevel()
    {
        BallsToSpawn = Random.Range(Level, Level + 2);
        //Debug.Log(BallsToSpawn);
        for (int i = 0; i < BallsToSpawn; i++)
        {
            Instantiate(BallPrefabs, SpawnPoint.position, Quaternion.identity);
        }
    }

    	private void Update() {
		if(BallsToSpawn == 0)
        {
            Level++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
	}

}
