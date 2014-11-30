using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			other.GetComponent<PlayerController>().health++;
			Destroy(transform.root.gameObject);
		}
	}
}
