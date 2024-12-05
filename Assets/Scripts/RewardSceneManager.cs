using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class RewardSceneManager : MonoBehaviour
{
    public Image image;
    public TMP_Text feedbackDialogueTMP;
    public TMP_Text notificationTextTMP;
    public GameObject GoodImage;
    public GameObject BadImage;
    public GameObject NextBtn;
    public GameObject RetryBtn;

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
            characterManager.setCompleted(currentCustomer);
            image.sprite = currentCustomer.happyFace;
            feedbackDialogueTMP.text = currentCustomer.goodText;
            notificationTextTMP.text = "YOU DID GREAT!";
            BadImage.SetActive(false);
            RetryBtn.SetActive(false);
        }
        else
        {
            image.sprite = currentCustomer.sadFace;
            notificationTextTMP.text = "OH NO!";
            feedbackDialogueTMP.text = currentCustomer.badText;
            GoodImage.SetActive(false);
            NextBtn.SetActive(false);
        }


    }


    bool matches(SnackData snack, CharacterData customer)
    {
        if (customer.characterName == "Benny The Biker") {
            if (snack.snackName == "Cookie" || snack.snackName == "Nut Bar") {
                return true;
            }
        } else if (customer.characterName == "Molly The Musician") {
            if (snack.snackName == "Fruit Snack") {
                return true;
            }
        } else if (customer.characterName == "Mr.Pickle The Pickle") {
            if (snack.snackName == "CheezIt") {
                return true;
            }
        }

        //     if (customer.characterName == "Benny The Biker")
        //     {
        //         if (snack.sugar > 31) // Twinkies
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        //     else if (customer.characterName == "Mr.Pickle The Pickle")
        //     {
        //         if (snack.sodium < 350)  //Twinkies
        //         {
        //             return false;
        //         }
        //         else
        //         {
        //             return true;
        //         }
        //     }
        //     else if (customer.characterName == "Tommy The Teacher")
        //     {
        //         if (snack.energy > 250 && snack.sugar <32) // protein bar
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             return false;
        //         }

        //     }
        //     else if (customer.characterName == "Penny The Police Officer")
        //     {
        //         // if ( fill with optido conditions ) 
        //         // {
        //         //     return true;
        //         // }

        //     }
        //     else if (customer.characterName == "Molly The Musician")
        //     {
        //         // if (filled with optido conditions)
        //         // {
        //         //     return true;
        //         // }


        //     }

        return false;
    }

    public void retryClicked()
    {
        SceneManager.LoadScene("SnaxDetection");
    }

    public void nextClicked()
    {
        SceneManager.LoadScene("CustomersList");
        List<CharacterData> remaining = characterManager.getRemainingCharacters();
        if (remaining.Count == 0)
        {
            SceneManager.LoadScene("FinalScene");
            return;
        }
    }


}
