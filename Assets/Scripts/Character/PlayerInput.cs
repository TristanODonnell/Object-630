using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    
    [SerializeField] private Vector2 directionToFace;
    [SerializeField] private float angleToTurn;
    private Player myPlayer;

    // Start is called before the first frame update
    void Start()
    {   
        
        myPlayer = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");

        Vector2 finalDirection = new Vector2(horizontalDirection, verticalDirection);

        directionToFace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angleToTurn = Mathf.Atan2(directionToFace.y - transform.position.y, directionToFace.x- transform.position.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angleToTurn);

        myPlayer.Move(finalDirection, angleToTurn);

        if (Input.GetMouseButtonDown(0))
        {
            myPlayer.Shoot();
        }
    }
}
