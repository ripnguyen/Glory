using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDownButton : MonoBehaviour {

	public void StrengthDown () {
		if (Stats.Strength > 1)
			Stats.Strength -= 1;
	}

	public void DexterityDown () {
		if (Stats.Dexterity > 1)
			Stats.Dexterity -= 1;
	}
	public void ConstitutionDown () {
		if (Stats.Constitution > 1)
			Stats.Constitution -= 1;
	}
	public void IntelligenceDown () {
		if (Stats.Intelligence > 1)
			Stats.Intelligence -= 1;
	}
	public void SpiritDown () {
		if (Stats.Spirit > 1)
			Stats.Spirit -= 1;
	}
}
