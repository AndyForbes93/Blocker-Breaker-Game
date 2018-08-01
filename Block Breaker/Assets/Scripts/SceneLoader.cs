using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    //move onto next level 
    public void LoadNextScene()
    {
        int currSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
