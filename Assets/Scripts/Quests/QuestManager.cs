﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quests;
    public bool[] questCompleted;

	// Use this for initialization
	void Start () {
        questCompleted = new bool[quests.Length];	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisplayQuestText(string text)
    {

    }
}