using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public Animator anim;
    public Rigidbody2D rb;

    public int jumpForce;

    public Transform groundPoint;

    public LayerMask groundLayer;

    public bool grounded;

    public Transform effectPosition;

    public GameObject deathEffect;

    public GameObject gameOver;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Update method used for physics in our game, because it happens every fixed amoun of time
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapPoint(groundPoint.position,groundLayer);
    }
    // Update is called once per frame
    void Update()
    {
       if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector2.up * jumpForce);
        }

        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("Grounded", grounded);
    }

    public void GameOver()
    {
        //Now just stop the camera controller and kill the player
        GameManager.instance.cam.followPlayer = false;
        //Instantiate a particle system as the death effect
        Instantiate(deathEffect, effectPosition.position, Quaternion.identity);
        gameOver.SetActive(true);
        Destroy(gameObject);
    }
}
