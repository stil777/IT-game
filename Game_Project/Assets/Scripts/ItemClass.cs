using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{
	//private GameObject Player;
	//public GameObject ManaHealth;

	// Use this for initialization

	
	void OnTriggerEnter2D(Collider2D other)
	{
		//ManaHealth.SetActive (false);
		if (other.tag == "Player")
		{
			other.GetComponent<PlayerController>().health++;
			Destroy(transform.root.gameObject);
		}
	
	}
}
