using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPrefabScript : MonoBehaviour
{
    public bool collidedWithPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player") 
        {
            collidedWithPlayer = true;
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collidedWithPlayer = false;
        }
    }
}
