using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class RewardSceneManager : MonoBehaviour
{
    public Image image;
    public TMP_Text feedbackDialogueTMP;
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
        string currentSnackBarcode = PlayerPrefs.GetString("CurrentSnackBarcode");
        Debug.Log("reward scene loading for " + currentCustomerName + " and " + currentSnackBarcode);

        currentSnack = snackManager.GetSnackByBarcode(currentSnackBarcode);
        currentCustomer = characterManager.GetCharacterByName(currentCustomerName);
        if (matches(currentSnack, currentCustomer))
        {
            image.sprite = currentCustomer.happyFace;
        }
        else
        {
            image.sprite = currentCustomer.sadFace;
        }


    }


    bool matches(SnackData snack, CharacterData customer)
    {
        Debug.Log("matching " + customer.characterName + " and " + snack.barcode);

        if (customer.characterName == "Benny The Biker")
        {
            if (snack.sugar > 31) // Twinkies
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (customer.characterName == "Mr.Pickle The Pickle")
        {
            if (snack.sodium < 350)  //Twinkies
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (customer.characterName == "Tommy The Teacher")
        {
            if (snack.energy > 250 && snack.sugar <32) // protein bar
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        else if (customer.characterName == "Penny The Police Officer")
        {
            if ( fill with optido conditions ) 
            {
                return true;
            }
           
        }
        else if (customer.characterName == "Molly The Musician")
        {
            if (filled with optido conditions)
            {
                return true;
            }
           
            
        }
        
        return false;
    }

}
