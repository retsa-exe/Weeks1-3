using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseControl : MonoBehaviour
{
    //horse speed
    public float speed = -3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get horse position
        Vector2 pos = transform.position;
        //move the horse every frame
        pos.x += speed * Time.deltaTime;

        //reverse the direction when reach the edge of the box
        if (pos.x < -3 || pos.x > 3)
        {
            speed = speed * -1;
        }

        //assign the position back to horse
        transform.position = pos;
    }
}
