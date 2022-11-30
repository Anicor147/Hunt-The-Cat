using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{   

    public float rightDistance;
    public float leftDistance;
    public float moveSpeed;
    private bool moveRight;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
        moveRight = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >rightDistance)
        {
            moveRight = false;

        }
        else if (transform.position.x < leftDistance)
        {
        moveRight = true;
        }

        if(moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else 
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }

        
    }
}
