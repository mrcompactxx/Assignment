using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public GameObject obstacle;
    public Vector3 offset;
    public Vector3 position;
    private GameObject obstaclePrefab;
    void Start()
    {
        offset = new Vector3 (0, 1, 0);
    }

    public void PlaceObstacle(GameObject tilePrefab) 
    {
        obstaclePrefab = Instantiate(obstacle,new Vector3(tilePrefab.transform.position.x+offset.x, tilePrefab.transform.position.y + offset.y, tilePrefab.transform.position.z + offset.z),Quaternion.identity);

        position = obstaclePrefab.transform.position;
    }

    void Update()
    {
        
    }
}
