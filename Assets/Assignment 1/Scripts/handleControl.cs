using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleControl : MonoBehaviour
{
    //check if the box is playing
    public bool isRunning = false;

    //record start time for timer
    float startTime;

    //aniamtion duration
    public float duration = 5f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && pos.x >= 6 && pos.x <= 8 && pos.y >= -5 && pos.y <= 0)
        {
            //set isRunning to true
            isRunning = true;
            //start the timer
            startTime = Time.time;
        }

        //set isRunning to flase after 5 sec
        if (isRunning && Time.time - startTime >= duration)
        {
            isRunning = false;
        }
    }
}
