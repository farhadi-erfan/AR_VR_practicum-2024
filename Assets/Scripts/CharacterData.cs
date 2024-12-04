using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character Data")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public string dialogue;
    public string condition;
    public string order;
    public float sodiumSensitivity;
    public float sugarSensitivity;
    public float fatSensitivity;
    public Sprite normalFace;
    public Sprite happyFace;
    public Sprite sadFace;
    public string goodText;
    public string badText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
