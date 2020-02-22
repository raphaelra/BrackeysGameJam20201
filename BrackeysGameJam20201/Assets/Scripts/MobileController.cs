using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        //dir.z = Input.acceleration.x;

         if (dir.sqrMagnitude > 1)
            {dir.Normalize();}
        dir *= Time.deltaTime;
        transform.Translate(dir * speed);


        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    //Debug.Log("no touchy");
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
}
