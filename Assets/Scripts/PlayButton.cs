using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	public void gameStart(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
