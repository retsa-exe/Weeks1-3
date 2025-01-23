using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool isJump = false;

    public float t;

    public AnimationCurve jumpCurve;
    public AnimationCurve flipCurve;

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isJump = true;
        }

        if (isJump)
        {
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
                isJump = false;
            }

            transform.position += Vector3.up * 5 * Time.deltaTime * jumpCurve.Evaluate(t) * speed;

        }
    }
}
