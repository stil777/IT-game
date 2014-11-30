using UnityEngine;
using System.Collections;

public class Loadlevel : MonoBehaviour {

//	private int left;
//	private int top;
//	public int width  = 150;
//	public int height = 30;

	void OnGUI (Collider2D other) {
//		makePlaceButton();
//		if (GUI.Button(new Rect(left, top, width, height), "Start Game")) {
//			Application.LoadLevel(this.gameScene);
//		}              
//	}
//	
//	void makePlaceButton() {
//		top  = (int)(Screen.height / 2 - this.height / 2);
//		left = (int)(Screen.width / 2 - this.width / 2 );
				if (other.tag == "Player") {
						if (this.tag == "StCard" && other.GetComponent<PlayerController> ().stsCards == 3) {
								GUI.Button (new Rect (10, 10, 50, 50), "Push!");
						}
				}
		}
}