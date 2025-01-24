using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform the mouse position to world point
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //set the position to the mouse poistion
        transform.position = pos;
    }
}
