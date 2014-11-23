using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{
	private GameObject Player;
	public GameObject ManaHealth;

	// Use this for initialization
	void Start ()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		//ManaHealth = GameObject.FindGameObjectWithTag ("Health");
	}
	
	void OnTriggerEnter(Collider other)
	{
		ManaHealth.SetActive (false);
	
	}
}
