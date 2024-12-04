using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class SimpleBarcodeScanner : MonoBehaviour
{

    BarcodeBehaviour mBarcodeBehaviour;
    private SnaxDetectionManager snaxDetectionManager;
    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
        snaxDetectionManager = FindFirstObjectByType<SnaxDetectionManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            string barcode = mBarcodeBehaviour.InstanceData.Text.Trim();
            //Debug.Log(barcode);
            //Debug.Log($"Raw barcode: '{mBarcodeBehaviour.InstanceData.Text}'");
            //Debug.Log($"Trimmed barcode: '{barcode}'");

            snaxDetectionManager.barcodeDetected(barcode);

            // if (barcode == "028400356145")
            // {
            //     myImage.gameObject.SetActive(true);
            //     name1.text = "Cheetos";
            //     fat.text = "Fat : 28g";
            //     sodium.text = "Sodium : 560mg";
            //     sugar.text = "Sugar : 3g";
            //     myImage.gameObject.SetActive(true);
            // }
            // else if (barcode == "041420081217")
            // {
            //     myImage.gameObject.SetActive(true);
            //     name1.text = "Juicy Burst";
            //     fat.text = "Fat : 0g";
            //     sodium.text = "Sodium : 70mg";
            //     sugar.text = "Sugar : 36g";
            // }
            // else if (barcode == "091752001001")
            // {
            //     name1.text = "BlueBerry Muffin";
            //     fat.text = "Fat : 17g";
            //     sodium.text = "Sodium : 460mg";
            //     sugar.text = "Sugar : 34g";
            //     myImage.gameObject.SetActive(true);
            // }
            // else if (barcode == "038000845246")
            // {
            //     name1.text = "Pringles";
            //     fat.text = "Fat : 22g";
            //     sodium.text = "Sodium : 360mg";
            //     sugar.text = "Sugar : 1g";
            //     myImage.gameObject.SetActive(true);
            // }
            // else if (barcode == "043695033007")
            // {
            //     name1.text = "HotPockets";
            //     fat.text = "Fat : 12g";
            //     sodium.text = "Sodium : 560mg";
            //     sugar.text = "Sugar : 3g";
            //     myImage.gameObject.SetActive(true);

            // }
            // else
            // {
            //     name1.text = mBarcodeBehaviour.InstanceData.Text;
            // }
        }
        else
        {
            snaxDetectionManager.noBarcodeSeen();
        }
    }
}
