using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Class used to register input from a user to signal a textbox to appear
public class ActivateText : MonoBehaviour {

    public TextAsset theText;

    public int startLine;
    public int endLine;

    public TextBoxManager textBox;

    public bool requireButton;
    public bool waitForButton;

	// Use this for initialization
	void Start () {
        textBox = FindObjectOfType<TextBoxManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if( waitForButton && Input.GetKeyDown(KeyCode.Return))
        {
            requireButton = true;
            textBox.currentLine = startLine;
            textBox.endLine = endLine;
            textBox.ReloadScript(theText);
            textBox.EnableTextBox();
        }
	}

    //Method to handle 2D collision zone to allow the player to interact
    //The 'return' key will be used to activate textboxes
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            waitForButton = true;
        }
    }

    //Method to deactivate the trigger so that the player can't activate dialouge after moving away
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            waitForButton = false;
        }
    }
}
