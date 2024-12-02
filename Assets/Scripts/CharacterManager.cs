using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterData[] allCharacters; // Reference to all available character data

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
}