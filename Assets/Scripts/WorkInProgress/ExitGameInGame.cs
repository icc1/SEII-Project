using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameInGame : MonoBehaviour {

	public void exit(bool selected)
	{
		if (selected == true) {
			Application.Quit ();
		}
	}
}
