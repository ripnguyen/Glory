using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;


public class StartButton : MonoBehaviour {

	public Text errorNoName;
	public Text errorStatsNotMax;
	public int errors;
	//string filePath = "Assets\\SaveData\\";
	string fileName;

	public void gameStart(string sceneName)
	{
		errors = 0;

		if (Stats.playerName == "") {
			errorNoName.enabled = true;
			errors++;
		}
		else {
			errorNoName.enabled = false;
		}

		if (Stats.totalStats != 20){
			errorStatsNotMax.enabled = true;
			errors++;
		}
		else {
			errorStatsNotMax.enabled = false;
		}
		
		if (errors == 0){
			SaveStats();
			SceneManager.LoadScene(sceneName);

		}
		
	}

	public void SaveStats() {
		fileName = "data.txt";
		StreamWriter mySW = new StreamWriter(fileName);

		mySW.WriteLine("Name:" + Stats.playerName);
		mySW.WriteLine("Strength:" + Stats.Strength);
		mySW.WriteLine("Dexterity:" + Stats.Dexterity);
		mySW.WriteLine("Constitution:" + Stats.Constitution);
		mySW.WriteLine("Intelligence:" + Stats.Intelligence);
		mySW.WriteLine("Spirit:" + Stats.Spirit);

		mySW.Flush();
		mySW.Close();
	}
}
