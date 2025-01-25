using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseControl : MonoBehaviour
{
    //get handle script to check if the box is running
    public handleControl handle;

    //horse speed
    public float speed = -3f;

    //
    public float amplitude = 0.5f;
    //
    public float frequency = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the box is running
        if (handle.isRunning)
        {
            //get horse position
            Vector2 pos = transform.position;
            //move the horse in x direction every frame
            pos.x += speed * Time.deltaTime;

            //add y direction movement
            pos.y = amplitude * Mathf.Sin(Time.time * frequency);

            //reverse the direction when reach the edge of the box
            if (pos.x < -3 || pos.x > 3)
            {
                speed = speed * -1;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }

            //assign the position back to horse
            transform.position = pos;
        }
    }
}
