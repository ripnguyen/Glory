using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTabs : MonoBehaviour {

// Tab states
	public enum MenuStates { Character, Hunt, Quests, Skills};
	public MenuStates currentMenuState;

	public enum InventoryStates { Equips, Use, Etc, Quest};
	public InventoryStates currentInventoryState;

// Tab Prefabs
	public GameObject characterTab;
	public GameObject huntTab;
	public GameObject questsTab;
	public GameObject skillsTab;
	
	void Awake()
	{
		// Character tab always loaded as primary tab
		currentMenuState = MenuStates.Character;
		currentInventoryState = InventoryStates.Equips;
	}

	void Update()
	{
		switch (currentMenuState)
		{
			case MenuStates.Character:
				characterTab.SetActive(true);
				huntTab.SetActive(false);
				questsTab.SetActive(false);
				skillsTab.SetActive(false);
				break;
			case MenuStates.Hunt:
				characterTab.SetActive(false);
				huntTab.SetActive(true);
				questsTab.SetActive(false);
				skillsTab.SetActive(false);
				break;
			case MenuStates.Quests:
				characterTab.SetActive(false);
				huntTab.SetActive(false);
				questsTab.SetActive(true);
				skillsTab.SetActive(false);
				break;
			case MenuStates.Skills:
				characterTab.SetActive(false);
				huntTab.SetActive(false);
				questsTab.SetActive(false);
				skillsTab.SetActive(true);
				break;
			default:
				break;

		}

	}
// For main menu tabs
	public void OnCharacterClick()
	{
		currentMenuState = MenuStates.Character;
	}

	public void OnHuntClick()
	{
		currentMenuState = MenuStates.Hunt;
	}

	public void OnQuestsClick()
	{
		currentMenuState = MenuStates.Quests;
	}

// For Character tabs
	public void OnSkillsClick()
	{
		currentMenuState = MenuStates.Skills;
	}


}
