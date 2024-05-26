using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private ObstaclesManager obstaclesManager;
    [SerializeField]private Vector3 offset;
    [SerializeField] private Vector3 movement;
    [SerializeField] private float speed;
    private GameObject player;
    public GameObject playerPrefab;
    private Vector3 currentPos;
    private Vector3 oldPos;

    void Start()
    {
        speed = 4f;
        playerPrefab = FindAnyObjectByType<GameObject>();
        obstaclesManager = FindAnyObjectByType <ObstaclesManager>();
        movement = new Vector3(0,1,0);
        player = Resources.Load<GameObject>("PlayerPrefab");
        playerPrefab = Instantiate(player,new Vector3(0,0+offset.y,0),Quaternion.identity);
    }

    void Update()
    {
        if (obstaclesManager != null) 
        {
            if (obstaclesManager.position == movement)
            {
                Debug.Log("Cant move");
            }
            else 
            {
                MovePlayer();

            }
        }

    }

    private void MovePlayer() 
    {
/*        playerPrefab.transform.position = new Vector3(movement.x, movement.y, movement.z);
*/
        playerPrefab.transform.position = Vector3.MoveTowards(playerPrefab.transform.position, movement, speed * Time.deltaTime);

    }

    private IEnumerator DisableInput()
    {

        yield return new WaitForSeconds(1f);
    }
}
