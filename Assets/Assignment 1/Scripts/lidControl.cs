using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lidControl : MonoBehaviour
{
    public bool lid = false;

    // Start is called before the first frame update
    void Start()
    {
        
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

        //show the lid when true
        if (lid)
        {
            transform.position = new Vector2(0, 0);
        }
        else
        {
            //remove the lid from screen if false
            transform.position = new Vector2(0, 7);
        }
    }
}
