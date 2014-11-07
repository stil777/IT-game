using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float maxSpeed = 10f;
	public int health = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (moveX * maxSpeed, moveY * maxSpeed);
	
	}
}
