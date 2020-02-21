using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static int Lives = 3;
    public static int BallsToSpawn;
    public static int Level = 1;
    private int LiveBalls;
    public GameObject BallPrefabs;
    public Transform SpawnPoint;
    public Text LevelText;
    public GameObject[] LifeIcons;


    void Start()
    {
        UpdateLevelText();
        UpdateLives();
        StartLevel();
    }

    void UpdateLevelText()
    {
        LevelText.text = "Level: " + Level;
    }

    void StartLevel()
    {
        BallsToSpawn = Random.Range(Level, Level + 2);
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


    void UpdateLives()
    {
        if (Lives == 3)
        {
            LifeIcons[0].SetActive(true);
            LifeIcons[1].SetActive(true);
            LifeIcons[2].SetActive(true);
        }
        if (Lives == 2)
        {
            LifeIcons[0].SetActive(true);
            LifeIcons[1].SetActive(true);
            LifeIcons[2].SetActive(false);
        }
        if (Lives == 1)
        {
            LifeIcons[0].SetActive(true);
            LifeIcons[1].SetActive(false);
            LifeIcons[2].SetActive(false);
        }
        if (Lives == 0)
        {
            LifeIcons[0].SetActive(false);
            LifeIcons[1].SetActive(false);
            LifeIcons[2].SetActive(false);
        }

    }

    public static void LoseLife()
    {
        Lives--;
        if (Manager.Lives < 0)
        {
            Lives = 3;
            Level = 1;
            SceneManager.LoadScene(2);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
