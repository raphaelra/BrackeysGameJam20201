using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public string GooglePlayID = "3475896";
    public bool TestMode = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GooglePlayID, TestMode);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //if(Advertisement.IsReady("Video"))
            {
            //Debug.Log("s");
            Time.timeScale = 0f;
            Advertisement.Show();
            //Advertisements.Show("Video");
            }
        }
    }
}
