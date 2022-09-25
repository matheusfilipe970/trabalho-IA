using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointTest : MonoBehaviour
{
    public Point point;
    public float speed;
    public int findValue;
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (point == null) 
            return;
        Vector3 dir = (point.transform.position - transform.position);
        if(dir.magnitude < 0.1)
        {
            if(point.valor == findValue)
            {
                point = null;
                return;
            }
            
            point = point.nextPoint;

            transform.position += dir.normalized * speed * Time.fixedDeltaTime;
        }

    }
  
}
