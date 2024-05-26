using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    public int x, y;
    public bool clicked;
    private ObstaclesManager obstacleManager;

    public void coords(int x, int y) 
    {
        this.x = x;
        this.y = y;
        gameObject.name = $"Position: {x},{y}";
    }

    public void DestroyTile() 
    {
        clicked = true;
        obstacleManager.PlaceObstacle(this.gameObject);
    }


    void Start()
    {
        obstacleManager = FindAnyObjectByType<ObstaclesManager>();
    }

    void Update()
    {
    }

}
