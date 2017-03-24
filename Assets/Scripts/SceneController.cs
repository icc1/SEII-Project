using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController: MonoBehaviour {
    
    void onTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered.");
        if (collider.name == "player")
        {

          //  gameObject.GetComponent<Renderer>().inbounds = true;
            //alternatly store that someone is in the bounds in a variable
            //in this script depending on which makes sense, for the player to
            //know or the object
        }
    }
        void OnCollisionEnter2D(Collision2D other)
        {
        SceneManager.LoadScene("Scenes/main", LoadSceneMode.Additive);
        }
    }
