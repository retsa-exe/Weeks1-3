using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note2Behaviour : MonoBehaviour
{
    //get the handle state
    public handleControl handle;
    //get lid state
    public lidControl lid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //show when the box is beingplayed
        if (handle.isRunning)
        {
            if (lid.lid)
            {
                transform.localScale = Vector3.one * 0;
            }
            else
            {
                transform.localScale = Vector3.one;
            }
        }
        else
        {
            transform.localScale = Vector3.one * 0;
        }
    }
}
