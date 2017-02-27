using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingBarProgress : MonoBehaviour {

    public float progress;

public IEnumerator AsynchronousLoad(AsyncOperation ao)
    {
        while (!ao.isDone)
        {
            progress = ao.progress;
            Debug.Log(progress);
            yield return null;
        }
    }
}
