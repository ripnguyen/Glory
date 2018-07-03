using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour {

	public static int Strength  = 1;
	public static int Dexterity = 1;
	public static int Constitution = 1;
	public static int Intelligence = 1;
	public static int Spirit = 1;
	public static int totalStats = Strength + Dexterity + Constitution + 
								   Intelligence + Spirit;
	public GameObject strengthDisplay;
	public GameObject dexterityDisplay;
	public GameObject constitutionDisplay;
	public GameObject intelligenceDisplay;
	public GameObject spiritDisplay;
	public InputField enterPlayerName;
	public Text errorNoName;
	public Text errorStatsNotMax;
	public int internalStrength;
	public int internalDexterity;
	public int internalConstitution;
	public int internalIntelligence;
	public int internalSpirit;
	public static string playerName = "";

	void Start () {
		errorNoName.enabled = false;
		errorStatsNotMax.enabled = false;
	}

	void Update () {
		internalStrength = Strength;
		internalDexterity = Dexterity;
		internalConstitution = Constitution;
		internalIntelligence = Intelligence;
		internalSpirit = Spirit;
		totalStats = Strength + Dexterity + Constitution + Intelligence + Spirit;
		strengthDisplay.GetComponent<Text>().text = "" + internalStrength;
		dexterityDisplay.GetComponent<Text>().text = "" + internalDexterity;
		constitutionDisplay.GetComponent<Text>().text = "" + internalConstitution;
		intelligenceDisplay.GetComponent<Text>().text = "" + internalIntelligence;
		spiritDisplay.GetComponent<Text>().text = "" + internalSpirit;

	}

	public void getPlayerName() {
		playerName = enterPlayerName.text;
	}
}

