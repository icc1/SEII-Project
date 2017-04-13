using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Persistence;

public class NPCControllerV2 : MonoBehaviour {
    private List<GameObject> NPCList;
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

}
