using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class continueButton : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public GameObject menu;
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void loadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        menu.SetActive(false);
        loadingScreen.SetActive(true);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = Mathf.RoundToInt( progress * 100 ) + "%";
            yield return null;
        }
    }
}
