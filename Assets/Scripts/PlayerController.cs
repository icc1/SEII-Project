using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;


    private bool playerMoving;
    private Animator animate;
    private Rigidbody2D playerRigidBody;
    private Vector2 lastMove;

    private static bool playerExists;

	// Use this for initialization
	void Start ()
    {

        animate = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            playerRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRigidBody.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x,Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);
        }
        if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 0f);
        }

        animate.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animate.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        animate.SetBool("PlayerMoving", playerMoving);
        animate.SetFloat("LastMoveX", lastMove.x);
        animate.SetFloat("LastMoveY", lastMove.y);

  
    }
}
