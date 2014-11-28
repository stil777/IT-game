using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (this.tag == "Health")
				other.GetComponent<PlayerController>().health++;
			if (this.tag == "StCard")
				other.GetComponent<PlayerController>().stsCards++;
			if (this.tag == "Key")
				other.GetComponent<PlayerController>().keys++;
			if (this.tag == "HWater")
				other.GetComponent<PlayerController>().holyWater++;
			if (this.tag == "UnionCard")
			{
				other.GetComponent<PlayerController>().unionCard = true;
				print ("You found Union Card");
			}
			if (this.tag == "LibCard")
			{
				other.GetComponent<PlayerController>().readCard = true;
				print ("You found Read Card");
			}
			if (this.tag == "Badge")
			{
				other.GetComponent<PlayerController>().policeBadge = true;
				print ("You found Police Badge");
			}
			if (this.tag == "Diploma")
				print ("You won a Game!");
			Destroy(transform.root.gameObject);
		}
	}
}
