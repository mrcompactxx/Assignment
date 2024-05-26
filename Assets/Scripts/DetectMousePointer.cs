using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMousePointer : MonoBehaviour
{

    
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit)) 
        {
            if (hit.collider.CompareTag("Box")) 
            {
                TileScript tile = hit.collider.GetComponent<TileScript>();
                GameObject tilePrefab = hit.collider.gameObject;
                Debug.Log(tilePrefab.name);
            }

        
        }

    }
}
