using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSwitcher : MonoBehaviour
{
    // References to the two panels (menus)
    public GameObject mainMenu;
    public GameObject menuOptions;
    public GameObject levelScreen;
    public GameObject levelOne;

    // Method to switch to the Settings Menu
    public void ShowMenuOptions()
    {
        // Enable Menu Screen and disable all others
        mainMenu.SetActive(false);
        levelScreen.SetActive(false);
        menuOptions.SetActive(true);
        levelOne.SetActive(false);
    }

    // Method to switch to the Main Menu
    public void ShowMainMenu()
    {
        // Enable MenuOptions Screen and disable all others
        menuOptions.SetActive(false);
        levelScreen.SetActive(false);
        mainMenu.SetActive(true);
        levelOne.SetActive(false);
    }

    public void ShowLevels()
    {
        // enable Levels Screen and disable all others
        menuOptions.SetActive(false);
        levelScreen.SetActive(true);
        mainMenu.SetActive(false);
        levelOne.SetActive(false);
    }

    public void ShowLevel1()
    {
        // enable Level1 Screen and disable all others
        menuOptions.SetActive(false);
        levelScreen.SetActive(false);
        mainMenu.SetActive(false);
        levelOne.SetActive(true);
    }

    public void StartScanScene()
    {
        // Load the scan scene 
        SceneManager.LoadScene("SnaxDetection");
    }

    public void StartOptiDot()
    {
        // Load the scan scene 
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("CustomersList");
    }
}
