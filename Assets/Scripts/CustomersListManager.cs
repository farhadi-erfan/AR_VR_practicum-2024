using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomersListManager : MonoBehaviour
{
    public TMP_Text characterNameTMP;
    public TMP_Text dialogueTMP;
    public TMP_Text conditionTMP;
    public Image characterAvatar;
    public GameObject secondCustomerButton;
    public GameObject thirdCustomerButton;
    private CharacterManager characterManager;

    string currentCustomerName = "Benny The Biker";
    string secondCustomerName = "Sir Scorch the Dragon";
    string thirdCustomerName = "Penelope the penguin";


    void Start()
    {
        characterManager = FindFirstObjectByType<CharacterManager>();
        updateUI();
    }

    void updateUI()
    {
        CharacterData customer = characterManager.GetCharacterByName(currentCustomerName);
        CharacterData secondCharacter = characterManager.GetCharacterByName(secondCustomerName);
        CharacterData thirdCharacter = characterManager.GetCharacterByName(thirdCustomerName);

        if (characterManager.isCharacterCompleted(customer)) {
            if (characterManager.isCharacterCompleted(secondCharacter))
            {
                if (characterManager.isCharacterCompleted(thirdCharacter))
                {
                    // TODO - Move to end page
                }
                else
                {
                    

                }
            }
        }


        setCurrentCustomer(customer);

        secondCustomerButton.GetComponent<Image>().sprite = secondCharacter.normalFace;
        thirdCustomerButton.GetComponent<Image>().sprite = thirdCharacter.normalFace;
    }

    // This method updates the UI with the selected character's information
    public void setCurrentCustomer(CharacterData character)
    {
        characterNameTMP.text = character.characterName;
        dialogueTMP.text = character.dialogue;
        conditionTMP.text = character.condition;
        characterAvatar.sprite = character.normalFace;
    }
    public void secondCustomerClicked()
    {
        string temp = currentCustomerName;
        currentCustomerName = secondCustomerName;
        secondCustomerName = temp;
        updateUI();
    }

    public void thirdCustomerClicked()
    {
        string temp = currentCustomerName;
        currentCustomerName = thirdCustomerName;
        thirdCustomerName = temp;
        updateUI();
    }

    public void startShopping()
    {
        PlayerPrefs.SetString("CurrentCustomer", currentCustomerName);
        SceneManager.LoadScene("SnaxDetection");
    }

}