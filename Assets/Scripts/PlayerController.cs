using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D myRigidbody;
	private Animator anim;
	private bool facingRight = false;
	private GameObject Enemy;
	//private GameObject Player;
	public float maxSpeed = 4f;

	public int maxHealth = 3;
	public int health = 3;
	public int stsCards = 0;
	public int holyWater = 0;
	public int keys = 0;
	public bool readCard = false;
	public bool policeBadge = false;
	public bool unionCard = false;

	private float lastHitTime = -3f;
	private float repeatDamagePeriod = 3f;

	// Use this for initialization
	void Start ()
	{
		//DontDestroyOnLoad (this);
		myRigidbody = this.rigidbody2D;
		anim = GetComponent<Animator> ();
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		//Player = GameObject.FindGameObjectWithTag ("Player");
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

		if (facingRight == true && moveX < 0)
		{
			Flip();
		}
		else if (facingRight == false && moveX > 0)
		{
			Flip();
		}

		//Taking damage
		Vector2 hurtVector = this.transform.position - Enemy.transform.position;
		if (Time.time > lastHitTime + repeatDamagePeriod)
		{
			if (health > 0)
			{
				if (hurtVector.x * hurtVector.x + hurtVector.y * hurtVector.y < 1.5f)
				{
					health--;
					lastHitTime = Time.time;
					//print("Health - " + health + "; Time: " + Time.time);
				}
			}
		}
		//print (health);
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
