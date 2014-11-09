using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private GameObject Enemy;
	private GameObject Player;
	private GameObject Wall;
	public float maxSpeed = 10f;
	public int health = 3;

	// Use this for initialization
	void Start ()
	{
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
		Wall = GameObject.FindGameObjectWithTag ("Wall");
	}
	
	// Update is called once per frame
	void Update ()
	{
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (moveX * maxSpeed, moveY * maxSpeed);
	
	}
}
