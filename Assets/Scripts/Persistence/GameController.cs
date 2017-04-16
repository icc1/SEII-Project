using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text;
using Assets.Scripts.Combat;
using Assets.Scripts.Combat_Interfaces;

namespace Assets.Scripts.Persistence
{
    //This is the class that will hold our Lists to modify during the game.

    public class GameController: MonoBehaviour
    {
        public static GameController Instance; 
        public List<GameObject> NPCS;
        public IPlayer player;
        public List<GameObject> KeyNPCS;
        public GameController gameController()
        {
            Debug.Log("PlayerController1 instance was called");
            //This is a singleton method that is a technique used to hold persistent data
            //This one can be used to store a list of our NPCs/objects so we do not have to use a "find."
            if (!Instance)
            {
                Instance = FindObjectOfType(typeof(GameController)) as GameController;
                if (!Instance)
                    Debug.LogError("We need an active NPC Controller in this scene.");

            }
            return Instance;
        }
        private void Awake(){
            Debug.Log("Ran upon Awake");
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
                NPCS = new List<GameObject>();
                KeyNPCS = new List<GameObject>();
                player = new Player();

            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
        private void Start()
        {

        }
        public void TestMethod()
        {
            Debug.Log("Test Method in GameController Ran");
            GameObject clone = Instantiate(GameObject.FindGameObjectWithTag("NPCModel")) as GameObject;
            NPCS.Add(clone);
        }

    }
}
