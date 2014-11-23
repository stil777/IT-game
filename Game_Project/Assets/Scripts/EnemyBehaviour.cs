using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
	public Transform Target;
	private GameObject Enemy;
	private GameObject Player;
	private bool facingRight = false;
	private float Range;
	public float Speed = 1.5f;
	private float MinDistance = 5f;

	// Use this for initialization
	void Start ()
	{
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{

		Range = Vector2.Distance (Enemy.transform.position, Player.transform.position);
		if (Range <= MinDistance)
		{
			int stepX = 1;
			int stepY = 1;
			if (Player.transform.position.x < Enemy.transform.position.x)
				stepX = -1;
			else if (Player.transform.position.x == Enemy.transform.position.x)
				stepX = 0;
			if (Player.transform.position.y < Enemy.transform.position.y)
				stepY = -1;
			else if (Player.transform.position.y == Enemy.transform.position.y)
				stepY = 0;
			float X = transform.position.x;
			float Y = transform.position.y;
			transform.position = Vector2.MoveTowards(new Vector2(X, Y),new Vector2(X + stepX * Speed, Y + stepY * Speed),3*Time.deltaTime);
			if (facingRight == true && stepX < 0)
			{
				Flip();
			}
			else if (facingRight == false && stepX > 0)
			{
				Flip();
			}
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
