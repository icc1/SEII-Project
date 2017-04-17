using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    public PlayerController player;

    public string[] textLines;
    public int currentLine;
    public int endLine;
    
    public bool isActive;
    

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        //Check if the text file exists. If it does write it into the array
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endLine == 0)
        {
            endLine = textLines.Length - 1;
        }

        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }

	}
	
	// Update is called once per frame
	void Update () {

        if (!isActive)
        {
            return;
        }

        if (endLine == 0)
        {
            endLine = textLines.Length - 1;
        }

        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if(currentLine > endLine)
        {
            DisableTextBox();
        }
	}

    //Method to make the text box visible
    public void EnableTextBox()
    {
        player.playerMoving = false;

        isActive = true;
        textBox.SetActive(true);
    } 

    //Method to remove the text box from the screen
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;

        player.playerMoving = true;
    }

    //Method to load in a new text file
    public void ReloadScript(TextAsset newText)
    {
        if(newText != null)
        {
            textLines = new string[1];
            textLines = (newText.text.Split('\n'));

        }
    }

}
