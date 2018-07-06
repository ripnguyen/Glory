using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Engine : MonoBehaviour {
	// Primary stats - loaded initially
	public static string playerName;
	public static int Strength;
	public static int Dexterity;
	public static int Constitution;
	public static int Intelligence;
	public static int Spirit;
	// Other stats - calculated after initial load
	public static int Physicaldmg;
	public static int Magicaldmg;
	public static int Armor;
	public static int Resist;
	public static int Healing;
	// Health and mana - load as bar
	public static int Health;
	public static int Mana;
	// Helper variables
	// Stat display objects
	public GameObject nameDisplay;
	public GameObject strengthDisplay;
	public GameObject dexterityDisplay;
	public GameObject constitutionDisplay;
	public GameObject intelligenceDisplay;
	public GameObject spiritDisplay;
	public GameObject physDisplay;
	public GameObject magDisplay;
	public GameObject armorDisplay;
	public GameObject resistDisplay;
	public GameObject healingDisplay;
	public GameObject healthDisplay;
	public GameObject manaDisplay;

	string fileName;

	void Start () 
	{
		fileName =  "data.txt";
		StreamReader mySR = new StreamReader(fileName);
		loadData(mySR);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void loadData (StreamReader mySR)
	{
		string line;

		// So far loads and renders primary stats
		while ((line = mySR.ReadLine()) != null){
			int index = line.IndexOf(":");
			string category = line.Substring(0, index);
			string value = line.Substring(index + 1, line.Length - 1 - index);
			
			switch (category)
			{
				case "Name":
					playerName = value;
					Debug.Log(value);
					break;
				case "Strength":
					Strength = int.Parse(value);
					break;
				case "Dexterity":
					Dexterity = int.Parse(value);
					Debug.Log(value);
					break;
				case "Constitution":
					Constitution = int.Parse(value);
					break;
				case "Intelligence":
					Intelligence = int.Parse(value);
					break;
				case "Spirit": 
					Spirit = int.Parse(value);
					break;
				default:
					Debug.Log("gg");
					break;
			}
		}

		mySR.Close();
		// IRender all stats
		nameDisplay.GetComponent<Text>().text = "Name: " + playerName;
		strengthDisplay.GetComponent<Text>().text += " " + Strength;
		dexterityDisplay.GetComponent<Text>().text = "Dexterity: " + Dexterity;
		constitutionDisplay.GetComponent<Text>().text += " " + Constitution;
		intelligenceDisplay.GetComponent<Text>().text += " " + Intelligence;
		spiritDisplay.GetComponent<Text>().text += " " + Spirit;
		physDisplay.GetComponent<Text>().text = "Physical DMG: " + (Strength + 10); 
		magDisplay.GetComponent<Text>().text = "Magical DMG: "  + (Intelligence + 10); 
		armorDisplay.GetComponent<Text>().text = "Armor: " + ((Constitution + 10) / 2); 
		resistDisplay.GetComponent<Text>().text = "Resist: " + ((Spirit + 10) / 2); 
		healingDisplay.GetComponent<Text>().text = "Healing: " + (Spirit + 10);
		healthDisplay.GetComponent<Text>().text = "Health: " + (100 + (Constitution * 5));
		manaDisplay.GetComponent<Text>().text =  "Mana: " + (50 + (Intelligence * 5));
	}


}
