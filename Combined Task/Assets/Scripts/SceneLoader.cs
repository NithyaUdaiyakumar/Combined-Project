using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
