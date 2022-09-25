using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    public enum direction { UNI, BI }
    public GameObject node1;
    public GameObject node2;
    public direction dir;

    
}

public class WPManager : MonoBehaviour
{
    public GameObject[] waypoints;
    //public GameObject waypointprefab;
    public Link[] links;
    public Grafo grafo = new Grafo();
  
    void Start()
    {
        if(waypoints.Length > 0)
        {
            foreach(GameObject wp in waypoints)
            {
                grafo.AddNode(wp);
            }
            foreach(Link l in links)
            {
                grafo.AddEdge(l.node1, l.node2);
                if (l.dir == Link.direction.BI)
                {
                    grafo.AddEdge(l.node2, l.node1);
                }
            }
        }       
    }

   
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            
                for(int i = 0; i < waypoints.Length; i++)
                {
                    Debug.Log("criou cubo");
                    Instantiate(waypointprefab);


                }
                
            
        }*/
    }
}
