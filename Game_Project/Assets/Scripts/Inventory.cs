using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	//private ItemSlot[] inventory;
	private GameObject player;
	public const int INVENTORY_SIZE = 5;
	private bool isOpened = false;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		//if (pressed "Shift") isOpened = !isOpened;
		//if (isOpened == true)
		//{
		//show inventory
		//}
	}
	/*
	class Item
	{
		
		string _name;
		int _maxQuantity;
		
		public Item () {
			string _name = string.Empty;
			int _maxQuantity = 0;
		}
		
		public string Name {
			get {return _name;}
			set {_name = value;}
		}
		
		public string MaxQuantity {
			get {return _maxQuantity ;}
			set {_maxQuantity = value;}
		}
	}

	public Inventory ()
	{
		ItemSlot[] inventory = new ItemSlot[INVENTORY_SIZE];
	}
	
	// add q item
	// returns if there was space in inventory or not
	public bool AddItem (Item item, int q)
	{
		
		// checks if the item already exist in inventory
		// adding to its stack
		for (int i = 0; i < INVENTORY_SIZE; i++)
		{
			if (inventory[i].item == item && inventory[i].item.MaxQuantity > inventory[i].quantity)
			{
				
				// if whole item fits
				if (q + inventory[i].quantity <= inventory[i].item.MaxQuantity)
				{
					Debug.Log ("Added to existing item in one stack " + q + "x " + item.Name);
					inventory[i].quantity += q;
					return true;
					
					// need more slots than 1
				}
				else
				{
					int spotsLeft = (inventory[i].item.MaxQuantity - inventory[i].quantity);
					Debug.Log("Added " + spotsLeft + "x " + item.Name + " at itemslot #" + i + " - " + q + " left.");
					q -= spotsLeft;
					inventory[i].quantity += spotsLeft;
					
					// no more items to add
					if (q == 0)
					{
						Debug.Log ("Added (by stacking) " + q + "x " + item.Name);
						return true;
					}
				}
			}
		}
		
		// still have items left in stack, add to a new slot
		for (int i = 0; i < INVENTORY_SIZE; i++)
		{
			if (inventory[i].item == null) {
				Debug.Log ("Added " + q + "x " + item.Name);
				inventory[i] = new ItemSlot (item, q);
				return true;
			}
		}
		
		Debug.LogWarning ("Inventory full! " + q + "x " + item.Name + " left.");
		return false;
	}
	
		
	// item at i has a q of 0, delete item
	private void DeleteItem (int i)
	{
		inventory [i].item = null;
	}


	// inventory
	class ItemSlot
	{
		public Item item;
		public int quantity;
	
		public ItemSlot (Item i, int q)
		{
			item = i;
			quantity = q;
		}
	}*/


}
