using UnityEngine;
using System.Collections;
using System; 

public class ItemClass : MonoBehaviour
{	public int isitaciv= 123;
	void OnTriggerEnter2D(Collider2D other)
	{
				if (other.tag == "Player") {
						if (this.tag == "Health" && other.GetComponent<PlayerController> ().health < other.GetComponent<PlayerController> ().maxHealth) {
								other.GetComponent<PlayerController> ().health++;
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "StCard") {
								other.GetComponent<PlayerController> ().stsCards++;
								Destroy (transform.root.gameObject);

						}
						if (this.tag == "Key") {
								other.GetComponent<PlayerController> ().keys++;
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "HWater") {
								other.GetComponent<PlayerController> ().holyWater++;
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "UnionCard") {
								other.GetComponent<PlayerController> ().unionCard = true;
								print ("You found Union Card");
								other.GetComponent<PlayerController> ().maxSpeed++;
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "LibCard") {
								other.GetComponent<PlayerController> ().readCard = true;
								print ("You found Read Card");
								other.GetComponent<PlayerController> ().maxHealth++;
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "Badge") {
								other.GetComponent<PlayerController> ().policeBadge = true;
								print ("You found Police Badge");
								Destroy (transform.root.gameObject);
						}
						if (this.tag == "Diploma")
								print ("You won a Game!");
				
						if (this.tag == "StCard") {
				if (other.GetComponent<PlayerController> ().stsCards == 3) {OnGUI();}
						}
				}
		}

	void OnGUI () {
		GUI.Button (new Rect (200, 200, 200, 30), "Achivment!");
	}
}