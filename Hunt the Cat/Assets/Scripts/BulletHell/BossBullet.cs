using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public PlayerHealth playerHealth;


    private Vector2 moveDirection;

    [SerializeField]
    private float moveSpeed;
    // Start is called before the first frame update

    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection*moveSpeed*Time.deltaTime);        
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }



    /*
     public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("DamageTaken");
            playerHealth.TakeDamage(DamageTaken);
        }
    }
    */
}
