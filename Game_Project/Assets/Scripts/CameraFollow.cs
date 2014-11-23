using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public float xMargin = 0f; // Distance in the x axis the player can move before the the camera follows
	public float yMargin = 0f; // Distance in the y axis the player can move before the the camera follows
	public float xSmooth = 8f; // How smoothly the camera catches up with it's target movement in the x axis
	public float ySmooth = 8f; // How smoothly the camera catches up with it's target movement in the y axis
	public Vector2 maxXandY; // The maximum x and y coordinates the camera can have
	public Vector2 minXandY; // The minimum x and y coordinates the camera can have
	public GUIElement gui;

	private GameObject player;
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	bool CheckXMargin ()
	{
		return Mathf.Abs(transform.position.x - player.transform.position.x) > xMargin;
	}

	bool CheckYMargin ()
	{
		return Mathf.Abs(transform.position.y - player.transform.position.y) > yMargin;
	}

	void FixedUpdate ()
	{
		TrackPlayer ();
		gui.guiText.text = "Health: " + ((int)(player.GetComponent<PlayerController> ().health)).ToString () + "   St's Cards: " + ((int)(player.GetComponent<PlayerController> ().stsCards)).ToString ();
	}

	void TrackPlayer ()
	{
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		if (CheckXMargin ()) targetX = Mathf.Lerp (transform.position.x, player.transform.position.x, xSmooth * Time.deltaTime);
		if (CheckYMargin ()) targetY = Mathf.Lerp (transform.position.y, player.transform.position.y, ySmooth * Time.deltaTime);

		targetX = Mathf.Clamp (targetX, minXandY.x, maxXandY.x);
		targetY = Mathf.Clamp (targetY, minXandY.y, maxXandY.y);

		transform.position = new Vector3 (targetX,targetY,transform.position.z);

	}
}
