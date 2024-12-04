using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSnack", menuName = "Snack Data")]
public class SnackData : ScriptableObject
{
    public string snackName;
    public string barcode;
    public float sodium;
    public float sugar;
    public float fat;
    public float energy;

    public float normalizedSodium;
    public float normalizedSugar;
    public float normalizedFat;
    public float NormalizedEnergy;

    public Sprite snackImage; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
