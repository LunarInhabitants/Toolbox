using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class ExampleScript : MonoBehaviour {

    [SerializeField]
    GameObject LoadingBar;


    // Use this for initialization
    void Start ()
    {
        if (SceneManager.GetActiveScene().name == "LoadingScene")
        {
            LoadNextScene();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (LoadingBar != null)
        {
            LoadingBarProgress p = GetComponent<LoadingBarProgress>();
            LoadingBar.transform.localScale = new Vector3( p.progress, LoadingBar.transform.localScale.y, LoadingBar.transform.localScale.z);
        }
	}

    public void LoadLoadingScreen()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    public void LoadNextScene()
    {
        LoadingBarProgress l = GetComponent<LoadingBarProgress>();
        StartCoroutine(l.AsynchronousLoad(SceneManager.LoadSceneAsync("Scene2")));
    }
}
