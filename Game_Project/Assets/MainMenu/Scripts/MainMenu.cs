using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public Texture backgroundTexture;
	public string CurrentMenu;

	void Start()
	{
		CurrentMenu = "Main";
	}

	void OnGUI()
	{
		if (CurrentMenu == "Main")
			Menu_Main();
		if (CurrentMenu == "Select")
			Menu_PlayerSelect();
		if (CurrentMenu == "Options")
			Menu_Options();
		if (CurrentMenu == "Achievements")
			Menu_Achievements();
	}

	public void NavGate(string nextMenu)
	{
		CurrentMenu = nextMenu;
	}

	private void Menu_Main()
	{
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .5f, Screen.width * .5f, Screen.height * .08f),"Play Game"))
		{
			print ("Clicked Play Game");
			NavGate("Select");
		}
		
		if (GUI.Button(new Rect(Screen.width * .55f, Screen.height * .62f, Screen.width * .4f, Screen.height * .05f),"Options"))
		{
			print ("Clicked Options");
			NavGate("Options");
		}
		
		if (GUI.Button(new Rect(Screen.width * .55f, Screen.height * .7f, Screen.width * .4f, Screen.height * .1f),"Achievements"))
		{
			print ("Clicked Achievements");
			NavGate("Achievements");
		}
	}

	private void Menu_PlayerSelect()
	{
		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .6f, Screen.width * .3f, Screen.height * .1f),"Back"))
		{
			NavGate("Main");
		}

		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .4f, Screen.width * .3f, Screen.height * .1f),"Start"))
		{
			Application.LoadLevel("Level0");
		}
	}

	private void Menu_Options()
	{
		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .6f, Screen.width * .5f, Screen.height * .05f),"Back"))
		{
			NavGate("Main");
		}
	}

	private void Menu_Achievements()
	{
		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .6f, Screen.width * .5f, Screen.height * .05f),"Back"))
		{
			NavGate("Main");
		}
	}
}
