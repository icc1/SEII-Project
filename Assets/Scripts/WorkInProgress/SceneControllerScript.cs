using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerScript : MonoBehaviour {

	// Use this for initialization
    //This class is purely a reference so we can instanciate copies of objects in different positions 
    //using scripts only, not using the Unity UI.
	void Awake() {
        SpriteRenderer spriteObject;
        GameObject NPCobject;
        Sprite[] sprite1;
        
        
        sprite1 = Resources.LoadAll<Sprite>("download");
        if (sprite1 == null)
            Debug.Log("Asset Rendering Failed");
        NPCobject = new GameObject();
        //NPCobject.name = "NPCname";
        NPCobject.AddComponent<Rigidbody2D>();
        Rigidbody2D rigidity = NPCobject.GetComponent<Rigidbody2D>();
        rigidity.gravityScale = 0;
        NPCobject.AddComponent<SpriteRenderer>();
        spriteObject = NPCobject.GetComponent<SpriteRenderer>();
        spriteObject.sprite = sprite1[0];
        NPCobject.transform.position = new Vector2(0, 0);
        //  NPCobject.layer = 32;
        //spriteObject.enabled = true;
        //Instantiate(NPCobject, NPCobject.transform.position, Quaternion.identity);
       // NPCobject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {



    }
        
}
