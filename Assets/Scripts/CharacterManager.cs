using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterData[] allCharacters; // Reference to all available character data
    List<string> completedCharacters;

    void Start()
    {
        if (PlayerPrefs.HasKey("MyStringList"))
        {
            string savedCompletedCharacters = PlayerPrefs.GetString("completedCharacters");
            completedCharacters = new List<string>(savedCompletedCharacters.Split(','));
        }
    }

    public CharacterData GetCharacterByName(string characterName)
    {
        foreach (var character in allCharacters)
        {
            if (character.characterName == characterName)
            {
                return character;
            }
        }
        return null; // Return null if character not found
    }

    public bool isCharacterCompleted(CharacterData character)
    {
        return completedCharacters.Contains(character.characterName);
    }

    public List<CharacterData> getRemainingCharacters()
    {
        List<CharacterData> characterQueue = new List<CharacterData>();
        foreach (var character in allCharacters)
        {
            if (!isCharacterCompleted(character)) {
                characterQueue.Add(character);
            }
        }
        return characterQueue;
    }
}