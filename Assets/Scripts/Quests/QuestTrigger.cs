using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {



    private QuestManager manage;
    public int questNum;
    public bool startQuest;
    public bool endQuest;

	// Use this for initialization
	void Start () {
        manage = FindObjectOfType<QuestManager>();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!manage.questCompleted[questNum])
            {
                if(startQuest && !manage.quests[questNum].gameObject.activeSelf)
                {
                    manage.quests[questNum].gameObject.SetActive(true);
                    manage.quests[questNum].questStart();
                }
                if(endQuest && manage.quests[questNum].gameObject.activeSelf)
                {
                    manage.quests[questNum].questEnd();
                }
            }
        }
    }
}
