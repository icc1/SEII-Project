using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Persistence;
using Assets.Scripts.NPCInterfaces;

public class NPCControllerV2 : MonoBehaviour {
    private List<GameObject> NPCList;
    private INpc npc;
    private Sprite[] spriteArray;
    private GameObject gameObject;
    private GameObject clone;
    private Vector3 spawnLocation;
    private void Awake()
    {
        NPCList = GameController.Instance.NPCS;
    }
    void Start()
    {
    }
    public void AddToList(GameObject gameObject)
    {
        NPCList.Add(gameObject);
    }
    public void RemoveFromList(GameObject gameObject)
    {
        NPCList.Remove(gameObject);
    }
    public void LoadNPCStoScene(int NumberOfScene)
    {
        //load npcs
        //spawnNPCSInScene
    }
    public void SpawnNPCsInScene()
    {
        //spawn NPCs at locations.
    }
    public void CreateNewNPC(INpc npc, Vector3 spawnLocation)
    {
        CloneNPC();
        spriteArray = Resources.LoadAll<Sprite>(npc.NPCSprite);
        if (spriteArray == null)
            Debug.Log("No Sprite Array found for NPC Object.");
        clone.GetComponent<SpriteRenderer>().sprite = spriteArray[npc.DefaultSpriteNumber];
        clone = Instantiate(clone, spawnLocation, Quaternion.identity);

    }
    private void CloneNPC()
    {
        if(clone == null)
            clone = Instantiate(GameObject.FindGameObjectWithTag("NPCModel")) as GameObject;
    }

}
