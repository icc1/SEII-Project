using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Animator animate;

	// Use this for initialization
	void Start ()
    {
        animate = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        else if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
        animate.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animate.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

    }
}
