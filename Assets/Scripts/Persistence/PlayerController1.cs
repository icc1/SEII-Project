using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Persistence;

public class PlayerController1 : MonoBehaviour {
    private static PlayerController1 playerController;
    private List<GameObject> NPCS;
    private IPlayerState playerState;
    public static PlayerController1 Instance ()
    {
        Debug.Log("PlayerController1 instance was called");
        //This is a singleton method that is a technique used to hold persistent data
        //This one can be used to store a list of our NPCs/objects so we do not have to use a "find."
        if (!playerController)
        {
            playerController = FindObjectOfType(typeof(PlayerController1)) as PlayerController1;
            if (!playerController)
                Debug.LogError("We need an active NPC Controller in this scene.");

        }
        return playerController;
    }

    private void Awake()
    {
        Debug.Log("Ran upon Awake");
        if(playerController == null)
        {
            DontDestroyOnLoad(gameObject);
            playerController = this;
        }
        else if(playerController != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        playerState = new PlayerState();
        Debug.Log("I started.");
    }
    public void AddToList(GameObject gameObject)
    {
        NPCS.Add(gameObject);
    }
    public void RemoveFromList(GameObject gameObject)
    {
        NPCS.Remove(gameObject);
    }
    public void SpawnNPCsInScene()
    {
        //spawn NPCs at locations.
    }

}
