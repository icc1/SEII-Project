using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.ThirdPerson;

public class GamePauseMenu : MonoBehaviour {

	public Transform Character;
	public Transform canvas;
	//public Transform pauseMenu;
	SaveGame saveGame;
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			PauseGame();
		}
	}

	public void PauseGame()
	{
		if (canvas.gameObject.activeInHierarchy == false) {
			//if (pauseMenu.gameObject.activeInHierarchy == false) {
			//pauseMenu.gameObject.SetActive (true);
			//}

			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			saveGame = gameObject.GetComponent<SaveGame> ();
			saveGame.SaveGameSetting (false);

		} 
		else {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}
}
