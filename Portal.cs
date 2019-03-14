using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal : MonoBehaviour {
    [SerializeField]
    private int _levelToLoad;
    [SerializeField]
    private GameObject _loadSlider;

    public Slider slide;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LoadLevel(_levelToLoad);
        }
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        _loadSlider.SetActive(true);

        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / .9f);

            slide.value = progress;

            yield return null;
        }
    }
}
