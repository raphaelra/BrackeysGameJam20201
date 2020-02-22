using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player.IsThereHole = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Player.IsThereHole = false;
            Destroy(this.gameObject);
        }

        if(Input.touchCount > 0)
         {
               Touch touch = Input.GetTouch(0);

              switch(touch.phase)
              {
                    case TouchPhase.Began:
                        Player.IsThereHole = false;
                        Destroy(this.gameObject);
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


 