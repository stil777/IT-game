using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public Texture backgroundTexture;

	void OnGUI()
	{
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .5f, Screen.width * .5f, Screen.height * .05f),"Play Game"))
		{
			print ("Clicked Play Game");
		}

		if (GUI.Button(new Rect(Screen.width * .55f, Screen.height * .6f, Screen.width * .4f, Screen.height * .05f),"Options"))
		{
			print ("Clicked Options");
		}
	}
}
