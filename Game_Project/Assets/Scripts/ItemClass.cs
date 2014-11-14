using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{
	private GameObject Player;
	private GameObject ManaHealth;

	// Use this for initialization
	void Start ()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		ManaHealth = GameObject.FindGameObjectWithTag ("Health");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
