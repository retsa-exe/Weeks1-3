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
    public float duration = 1f;

    //the range of handle moving
    public float moveRange = 5f;

    //handle animation curve
    public AnimationCurve handleCurve;

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

        //play handle animation
        if (isRunning)
        {
            //set isRunning to false after 5 sec
            if (Time.time - startTime >= duration)
            {
                isRunning = false;
            }
            else
            {
                //normalize animation time
                float t = (Time.time - startTime) / duration;
                //get curved value from the animation curve
                float curveValue = handleCurve.Evaluate(t);

                //calculate the value changed
                float yPos = Mathf.Lerp(-moveRange, moveRange, curveValue);

                //move the habdle by asign a new vector
                transform.localPosition = new Vector2(transform.localPosition.x, yPos - 2.5f);
            }
        }
    }
}
