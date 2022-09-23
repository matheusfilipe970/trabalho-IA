using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Point nextPoint;
    public int valor;

    void Start()
    {
        valor = Random.Range(0, 10);
    }


}
