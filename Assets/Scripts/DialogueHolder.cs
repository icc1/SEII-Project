using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager diaManage;

	// Use this for initialization
	void Start () {
        diaManage = FindObjectOfType<DialogueManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                diaManage.ShowBox(dialogue);
            }
        }
    }
}
