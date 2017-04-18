using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{

    public int questNumber;
    public QuestManager questManager;
    public string startingText;
    public string endingText;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    public void questStart()
    {
        questManager.DisplayQuestText(startingText);
    }

    public void questEnd()
    {
        questManager.questCompleted[questNumber] = true;
        gameObject.SetActive(false);

        questManager.DisplayQuestText(endingText);
    }
}
