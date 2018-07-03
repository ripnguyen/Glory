using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatUpButton : MonoBehaviour {	

	public bool isMax (){
		if (Stats.totalStats == 20){
			return true;
		}
		
		return false;
	}

	public void StrengthUp () {
		if (!isMax())
			Stats.Strength += 1;
	}

	public void DexterityUp () {
		if (!isMax())
			Stats.Dexterity += 1;
	}
	public void ConstitutionUp () {
		if (!isMax())
			Stats.Constitution += 1;
	}
	public void IntelligenceUp () {
		if (!isMax())
			Stats.Intelligence += 1;
	}
	public void SpiritUp () {
		if (!isMax())
			Stats.Spirit += 1;
	}
}
