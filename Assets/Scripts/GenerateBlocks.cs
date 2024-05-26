using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GenerateBlocks : MonoBehaviour
{

    [SerializeField]private int height;
    [SerializeField]private int width;
    [SerializeField] private GameObject tile;
    private ObstaclesManager obstaclesManager;
    void Start()
    {
        obstaclesManager = FindAnyObjectByType<ObstaclesManager>();
        GenerateTiles();
    }
   
    private void GenerateTiles() 
    {
        for (int i=0;i<width;i++) 
        {
            for(int j=0;j<height;j++) 
            {
                GameObject tilePrefab = Instantiate(tile, new Vector3(i, 0, j), Quaternion.identity);
                tilePrefab.GetComponent<TileScript>().coords(i,j);
            }
        }
        

    }

    void Update()
    {
       
    }
}
