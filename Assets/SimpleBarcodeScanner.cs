using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class SimpleBarcodeScanner : MonoBehaviour
{
    public TMPro.TextMeshProUGUI name1;
    public TMPro.TextMeshProUGUI fat;
    public TMPro.TextMeshProUGUI sodium;
    public TMPro.TextMeshProUGUI sugar;
    public UnityEngine.UI.Image myImage;
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
            Debug.Log($"Raw barcode: '{mBarcodeBehaviour.InstanceData.Text}'");
            Debug.Log($"Trimmed barcode: '{barcode}'");

            if (barcode == "01212901") {
                    myImage.gameObject.SetActive(true);
                    name1.text = "Coke";
                    fat.text = "Fat : 0g";
                    sodium.text = "Sodium : 55mg";
                    sugar.text = "Sugar : 69g";
                    myImage.gameObject.SetActive(true);
            }else  if (barcode == "3811") {
                    myImage.gameObject.SetActive(true);
                    name1.text = "Brad's Cookie Nook";
                    fat.text = "Fat : 7.4g";
                    sodium.text = "Sodium : 93mg";
                    sugar.text = "Sugar : 9.9g";
            } else if(barcode == "091752001001"){
                     name1.text = "BlueBerry Muffin";
                     fat.text = "Fat : 17g";
                    sodium.text = "Sodium : 460mg";
                    sugar.text = "Sugar : 34g";
                     myImage.gameObject.SetActive(true);
            }  else if(barcode == "038000845246"){
                    name1.text = "Pringles";
                    fat.text = "Fat : 22g";
                    sodium.text = "Sodium : 360mg";
                    sugar.text = "Sugar : 1g";
                     myImage.gameObject.SetActive(true);
            } else  if(barcode == "043695033007"){
                    name1.text = "HotPockets";
                    fat.text = "Fat : 12g";
                    sodium.text = "Sodium : 560mg";
                    sugar.text = "Sugar : 3g";
                    myImage.gameObject.SetActive(true);

            } else {
               name1.text = mBarcodeBehaviour.InstanceData.Text; 
            }
            // barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
        }
        else
        {
            name1.text = "";
            myImage.gameObject.SetActive(false);
        }
    }
}
