using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portrait : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Menu Principal")
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        if((sceneName == "Cabine") || (sceneName == "Viagem"))
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }
    }
}
