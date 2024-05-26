using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool collidedWithPlayer;
    private float speed;
    private enemyPrefabScript enemyScript;
    [SerializeField]private Player player;
    [SerializeField]private GameObject enemy;
    private GameObject enemyPrefab;
    void Start()
    {
        speed = 1f;
        player = FindAnyObjectByType<Player>();
        enemy = Resources.Load<GameObject>("Enemy");
        enemyPrefab = Instantiate(enemy,new Vector3(3,1,0),Quaternion.identity);
        enemyScript = enemyPrefab.GetComponent<enemyPrefabScript>();
    }

    void Update()
    {
        Vector3 playerPos = player.playerPrefab.transform.position;
        if (!enemyScript.collidedWithPlayer) 
        {
            FollowPlayer(player.playerPrefab);
        }

        Debug.Log(collidedWithPlayer);
        
        
    }

    private void FollowPlayer(GameObject player) 
    {
        enemyPrefab.transform.position = Vector3.MoveTowards(enemyPrefab.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    
}
