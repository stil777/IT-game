using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
	public Transform Target;
	private GameObject Enemy;
	private GameObject Player;
	private GameObject Wall;
	private float Range;
	public float Speed = 2f;
	private float MinDistance = 5f;

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
			//transform.Translate(Vector2.MoveTowards(Enemy.transform.position,Player.transform.position,Range)*Speed*Time.deltaTime);
		}
	}
}
