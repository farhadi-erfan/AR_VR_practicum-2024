using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LoadSnaxRay()
    {
        SceneManager.LoadSceneAsync("SnaxDetection");
    }
    //Start Scene
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Main_scene");
        IsChallengeManager.SetChallenge1State(false);
    }

    //Main Menu Controller

    public void LoadMainScene()
    {
        SceneManager.LoadSceneAsync("Main_scene");
        IsChallengeManager.SetChallenge1State(false);
    }

    public void LoadScene1()
    {
        SceneManager.LoadSceneAsync("UserScene1");
        IsChallengeManager.SetChallenge1State(false);
    }

    public void LoadScene2()
    {
        SceneManager.LoadSceneAsync("Challenge1");
        IsChallengeManager.SetChallenge1State(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
