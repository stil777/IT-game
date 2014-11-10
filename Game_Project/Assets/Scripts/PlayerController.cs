using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D myRigidbody;
	private Animator anim;
	private bool facingRigt = false;
	private GameObject Enemy;
	private GameObject Player;
	private GameObject Wall;
	private float maxSpeed = 2f;
	public int health = 3;

	// Use this for initialization
	void Start ()
	{
		myRigidbody = this.rigidbody2D;
		anim = GetComponent<Animator> ();
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
		Wall = GameObject.FindGameObjectWithTag ("Wall");
	}
	
	// Update is called once per frame
	void Update ()
	{
		float moveX = Input.GetAxisRaw ("Horizontal");
		float moveY = Input.GetAxisRaw ("Vertical");
		float posX = 0;
		float posY = 0;
		if (myRigidbody.velocity.x != posX) anim.SetFloat ("Speed", Mathf.Abs(moveX));
		else if (myRigidbody.velocity.y != posY) anim.SetFloat ("Speed", Mathf.Abs(moveY));
		myRigidbody.velocity = new Vector2 (moveX * maxSpeed, moveY * maxSpeed);

		if (facingRigt == true && moveX < 0)
		{
			facingRigt = false;
			transform.rotation = Quaternion.Euler(transform.rotation.x,0,transform.rotation.z);
		}
		else if (facingRigt == false && moveX > 0)
		{
			facingRigt = true;
			transform.rotation = Quaternion.Euler(transform.rotation.x,180,transform.rotation.z);
		}

		//anim.SetFloat ("Speed", Mathf.Abs(moveY));

	
	}
}
