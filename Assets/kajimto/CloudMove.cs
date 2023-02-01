using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    private float speed = 5.0f;
    private bool flag;

    void Update()
    {
        if (transform.position.x >= 20)
            flag = true;

        else if (transform.position.x <= -20)
            flag = false;

        if (flag)
            transform.position =
            Vector2.MoveTowards(transform.position, new Vector2(-25, 0), speed * Time.deltaTime);

        else if (!flag)
            transform.position =
            Vector2.MoveTowards(transform.position, new Vector2(25, 0), speed * Time.deltaTime);
    }
}
