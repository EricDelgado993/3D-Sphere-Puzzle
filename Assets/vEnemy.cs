using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vEnemy : MonoBehaviour
{
    public float speed=3f;
    public float leftAndRightEdge =8f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;
        
        if (pos.z < -leftAndRightEdge)
        {
            speed = 8;
        }

        else if (pos.z > leftAndRightEdge)
        {
            speed = -8;
        }
    }
}