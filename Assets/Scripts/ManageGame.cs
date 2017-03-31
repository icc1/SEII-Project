using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour {

	public Transform mainMenu;
	public Transform aboutMenu;

	public void loadGameState(string state)
	{
		Application.LoadLevel (state);
	}

	public void about(bool selected)
	{
		if (selected == true) {
			aboutMenu.gameObject.SetActive (selected);
			mainMenu.gameObject.SetActive (false);
		} else {
			aboutMenu.gameObject.SetActive (selected);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void exitGame()
	{
		Application.Quit();
	}
}
