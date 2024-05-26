using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField]private GameObject tile;
    [SerializeField]private Vector3 offset;
    void Start()
    {
        tile = Resources.Load<GameObject>("block");
    }

    void Update()
    {
        transform.position = new Vector3(tile.transform.position.x+offset.x, tile.transform.position.y + offset.y+ tile.transform.position.z + offset.z);   
    }
}
