using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour {

    public string levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            transform.position = new Vector3(2, 7, 0);
            Application.LoadLevel(levelToLoad);
            //transform.position = new Vector3(2, 7, 0);
            
        }

    }
}
