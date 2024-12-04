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

    public PolarizingFilm customerSugarSensitivity;
    public PolarizingFilm customerSodiumSensitivity;
    public PolarizingFilm customerFatSensitivity;

    private DesignerModeScreen designerModeScreen;
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

        snackSugar.SetFixedValue(currentSnack.normalizedSugar);
        snackSodium.SetFixedValue(currentSnack.normalizedSodium);
        snackFat.SetFixedValue(currentSnack.normalizedFat);

        customerSugarSensitivity.SetFixedValue(currentCustomer.sugarSensitivity);
        customerSodiumSensitivity.SetFixedValue(currentCustomer.sodiumSensitivity);
        customerFatSensitivity.SetFixedValue(currentCustomer.fatSensitivity);

        Debug.Log("inspect scene updated values of films");

        designerModeScreen = FindFirstObjectByType<DesignerModeScreen>();
        designerModeScreen.a1 = currentCustomer.sugarSensitivity;
        designerModeScreen.a2 = currentCustomer.sodiumSensitivity;
        designerModeScreen.a3 = currentCustomer.fatSensitivity;

        designerModeScreen.b1 = currentSnack.normalizedSugar;
        designerModeScreen.b2 = currentSnack.normalizedSodium;
        designerModeScreen.b3 = currentSnack.normalizedFat;

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
