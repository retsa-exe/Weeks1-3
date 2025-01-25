using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lidControl : MonoBehaviour
{
    //the state of the lid
    public bool lid = false;
    //the speed of the lid animation
    public float lidSpeed = 2f;
    //where are the lid going
    Vector2 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        //close the lid when start
        targetPos = new Vector2(0,0);
        transform.position = targetPos;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //get lid position
        Vector2 lipPos = transform.position;

        //change lid if mouse is clicked on it
        if (Input.GetMouseButtonDown(0) && pos.x >= -4.5 && pos.x <= 4.5 && pos.y >= 0 && pos.y <= 4) {
            lid = ! lid;
        }

        //change the target position
        if (lid)
        {
            targetPos = new Vector2(0, 0);
        }
        else
        {
            targetPos = new Vector2(0, 7);
        }

        //move the lid to the target position
        transform.position = Vector2.Lerp(transform.position, targetPos, Time.deltaTime * lidSpeed);
    }
}
