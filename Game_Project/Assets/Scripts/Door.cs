using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	private Animator anim;
	private GameObject player;

	void Start()
	{
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		if ((int)(player.GetComponent<PlayerController> ().stsCards) > 0)
			anim.SetBool ("StCards", true);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (other.GetComponent<PlayerController>().stsCards > 0) {// TODO: 0 must be changed to the number of stsCards from current level
				Application.LoadLevel("Level1");}// TODO: Go to NEXT level, create a set of level names
		}
	}
}
