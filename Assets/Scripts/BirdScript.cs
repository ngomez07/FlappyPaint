using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Animator flap;
    public Animator death;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) 
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            Debug.Log(transform.position.y);
            flap.SetTrigger("Up");
        }
        else
        {
            flap.SetTrigger("Down");
        }
        if (transform.position.y < -7 || transform.position.y > 7)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        death.SetTrigger("Death");
    }
    public void Jump()
    {
        if (birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            Debug.Log(transform.position.y);
        }
    }
}
