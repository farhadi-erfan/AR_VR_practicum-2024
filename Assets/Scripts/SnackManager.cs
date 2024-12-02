using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackManager : MonoBehaviour
{
    public SnackData[] allSnacks;

    public SnackData GetSnackByBarcode(string barcode)
    {
        foreach (var snack in allSnacks)
        {
            if (snack.barcode == barcode)
            {
                return snack;
            }
        }
        return null; // Return null if character not found
    }
}
