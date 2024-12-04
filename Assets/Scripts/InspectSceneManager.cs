using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InspectSceneManager : MonoBehaviour
{
    public Image snackImage;
    public Image userImage;


    public PolarizingFilm snackSugar;
    public PolarizingFilm snackSodium;
    public PolarizingFilm snackFat;

    public PolarizingFilm customerSugarTolerance;
    public PolarizingFilm customerSodiumTolerance;
    public PolarizingFilm customerFatTolerance;


    private SnackManager snackManager;
    private CharacterManager characterManager;
    SnackData currentSnack;
    CharacterData currentCustomer;


    // Start is called before the first frame update
    void Start()
    {
        characterManager = FindFirstObjectByType<CharacterManager>();
        snackManager = FindFirstObjectByType<SnackManager>();
        string currentCustomerName = PlayerPrefs.GetString("CurrentCustomer");
        string currentSnackBarcode = PlayerPrefs.GetString("InspectingSnackBarcode");
        Debug.Log("Inspect scene loading for " + currentCustomerName + " and " + currentSnackBarcode);

        currentSnack = snackManager.GetSnackByBarcode(currentSnackBarcode);
        currentCustomer = characterManager.GetCharacterByName(currentCustomerName);

        userImage.sprite = currentCustomer.normalFace;
        snackImage.sprite = currentSnack.snackImage;

        snackSugar.SetValue(currentSnack.normalizedSugar);
        Debug.Log(currentSnack.normalizedSugar);
        snackSodium.SetValue(currentSnack.normalizedSodium);
        Debug.Log(currentSnack.normalizedSodium);
        snackFat.SetValue(currentSnack.normalizedFat);
        Debug.Log(currentSnack.normalizedFat);

        customerSugarTolerance.SetValue(currentCustomer.sugarTolerance);
        customerSodiumTolerance.SetValue(currentCustomer.sodiumTolerance);
        customerFatTolerance.SetValue(currentCustomer.fatTolerance);
    }

    public void backClicked()
    {
        SceneManager.LoadScene("SnaxDetection");
    }

    public void buyClicked()
    {
        Debug.Log("Buy Clicked");
        PlayerPrefs.SetString("CurrentCustomer", currentCustomer.characterName);
        PlayerPrefs.SetString("CurrentSnackBarcode", currentSnack.barcode);
        SceneManager.LoadScene("RewardScene");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
