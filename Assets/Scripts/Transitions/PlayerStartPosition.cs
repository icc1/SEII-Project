using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour {

    private PlayerController player;
    //private cameraController camera;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        player.transform.position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
