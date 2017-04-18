using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private float zoom = -3;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, zoom);
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, zoom);
    }
}
