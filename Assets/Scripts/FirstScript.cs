using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
