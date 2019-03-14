using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    private int _loadLevel;

    [SerializeField]private GameObject _button, _alert;


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        yield return null;
    }

        public void Return()
    {
        _loadLevel = 0;
        Cursor.visible = true;
        LoadLevel(_loadLevel);
    }

    public void Cabine()
    {
        _loadLevel = 1;

        LoadLevel(_loadLevel);
    }

    public void Voo()
    {
        _loadLevel = 2;

        LoadLevel(_loadLevel);
    }

    public void Quiting()
    {
        Application.Quit();
    }

    public void Opera2()
    {
        Application.OpenURL("http://www.opera2.com.br/");
    }

}
