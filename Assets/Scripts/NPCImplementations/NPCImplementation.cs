using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Combat_Interfaces;
using Assets.Scripts.Persistence;
[RequireComponent(typeof(IStats))]
public class NPCImplementation : MonoBehaviour {
   // private GameController gameController;

    private bool inRange;
	// Use this for initialization
	void Start () {
       // gameController = GameController.Instance();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUp()
    {
        Debug.Log("Mouse Up'd");
        //display Canvas for this NPC when InRange = true.
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  collision.gameObject.GetComponent<typeof(IStats)>
        Debug.Log("OnCollisionEnter");
        //set Variable to true for when clicking on the NPC

        Debug.Log("Player Attack is currently" + GameController.Instance.playerState.Attack);
        GameController.Instance.playerState.Attack += 5;
        Debug.Log("Player Attack is  now" + GameController.Instance.playerState.Attack);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        string tagName = collision.gameObject.tag;
        Debug.Log("OnCollisionExit" + tagName);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D");
    }
}
