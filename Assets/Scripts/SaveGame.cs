using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveGame : MonoBehaviour {

	public Transform Character;

	public void SaveGameSetting(bool quit)
	{
		PlayerPrefs.SetFloat ("x", Character.position.x);
		PlayerPrefs.SetFloat ("y", Character.position.y);
        

		if (quit) {
			Time.timeScale = 1;
		}
	}

	void Awake()
	{
		Character.position = new Vector2 (PlayerPrefs.GetFloat ("x"),
			PlayerPrefs.GetFloat ("y"));
	}
}
