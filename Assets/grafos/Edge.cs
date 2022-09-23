using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
    public Node startNode;
    public Node endNode;

    public Edge(Node inicio, Node destino)
    {
        startNode = inicio;
        endNode = destino;
    }
}
