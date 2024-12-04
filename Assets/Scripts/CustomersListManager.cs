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

    CharacterData currentCustomer;
    CharacterData secondCustomer;
    CharacterData thirdCustomer;


    void Start()
    {
        characterManager = FindFirstObjectByType<CharacterManager>();
        List<CharacterData> remaining = characterManager.getRemainingCharacters();
        if (remaining.Count == 0)
        {
            // TODO goto end.
            return;
        }
        else if (remaining.Count == 1)
        {
            secondCustomerButton.SetActive(false);
            thirdCustomerButton.SetActive(false);
        }
        else if (remaining.Count == 2)
        {
            thirdCustomerButton.SetActive(false);
            secondCustomer = remaining[1];
        }
        else
        {
            secondCustomer = remaining[1];
            thirdCustomer = remaining[2];
        }
        currentCustomer = remaining[0];

        updateUI();
    }

    void updateUI()
    {
        setCurrentCustomer(currentCustomer);
        if (secondCustomer != null)
        {
            secondCustomerButton.GetComponent<Image>().sprite = secondCustomer.normalFace;
        }
        if (thirdCustomer != null)
        {
            thirdCustomerButton.GetComponent<Image>().sprite = thirdCustomer.normalFace;
        }
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
        CharacterData temp = currentCustomer;
        currentCustomer = secondCustomer;
        secondCustomer = temp;
        updateUI();
    }

    public void thirdCustomerClicked()
    {
        CharacterData temp = currentCustomer;
        currentCustomer = thirdCustomer;
        thirdCustomer = temp;
        updateUI();
    }

    public void startShopping()
    {
        PlayerPrefs.SetString("CurrentCustomer", currentCustomer.characterName);
        SceneManager.LoadScene("SnaxDetection");
    }

}