using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Assets.Scripts.Persistence;

public class SceneController2: MonoBehaviour {
    private List<GameObject> NPCS;

    //upon start spawn new npcs
    private void Start()
    {
        NPCS = GameController.Instance.NPCS;
        GameController.Instance.TestMethod();
        Sprite[] sprite1;


        sprite1 = Resources.LoadAll<Sprite>("download");
        if (sprite1 == null)
            Debug.Log("Asset Rendering Failed");
        foreach (GameObject NPC in NPCS)
        {
            Debug.Log("GameObject instantiated");
            NPC.GetComponent<SpriteRenderer>().sprite = sprite1[61];
            Instantiate(NPC, new Vector3(-0.741F, .975F), Quaternion.identity);

            //Instantiate(NPC, new Vector3(-1.871F, 0.985F), Quaternion.identity);
        }
        //GameController.Instance.playerState.Attack += 5;
        //Debug.Log("Player Attack = " + GameController.Instance.playerState.Attack);
    }
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
        SceneManager.UnloadSceneAsync("main");
        SceneManager.LoadScene("Scenes/Town", LoadSceneMode.Additive);
       // GameController.Instance.playerState.Attack += 5;
        //Debug.Log("Player Attack = " + GameController.Instance.playerState.Attack);
    }
    }
