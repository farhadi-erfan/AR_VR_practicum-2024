using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SimpleBarcodeScanner : MonoBehaviour
{
    public TMPro.TextMeshProUGUI barcodeAsText;
    BarcodeBehaviour mBarcodeBehaviour;
    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            string barcode = mBarcodeBehaviour.InstanceData.Text.Trim();
            Debug.Log(barcode);
            if (barcode == "01212901") {
                barcodeAsText.text = "Coke";
            } else if (barcode == "some") {

            } else {
               barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text; 
            }
            // barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
        }
        else
        {
            barcodeAsText.text = "";
        }
    }
}
