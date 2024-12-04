using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DesignerModeScreen : MonoBehaviour
{
    public Transform text;
    public float value;

    public bool isChallenge1 = false;

    public float a1; // green
    public float a2; // blue
    public float a3; // red
    public float a4; // extra beam on the left
    public float a5; // extra beam on the right
    public float a6;
    public float a7;
    public float b1;
    public float b2;
    public float b3;
    public float b4;
    public float b5;
    public float b6;
    public float b7;

    public GameObject extraPathLeft1;
    public GameObject extraPathLeft2;
    public GameObject extraPathRight1;
    public GameObject extraPathRight2;
    private PolarizingFilm film11;
    private PolarizingFilm film12;
    private PolarizingFilm film13;
    private PolarizingFilm film14;
    private PolarizingFilm film15;
    private PolarizingFilm film16;
    private PolarizingFilm film17;
    private PolarizingFilm film21;
    private PolarizingFilm film22;
    private PolarizingFilm film23;
    private PolarizingFilm film24;
    private PolarizingFilm film25;
    private PolarizingFilm film26;
    private PolarizingFilm film27;

    private Button buttonSweetness;
    private Button buttonSalinity;
    private Button buttonGreasiness;
    private Button buttonLeft1;
    private Button buttonRight1;
    private Button buttonLeft2;
    private Button buttonRight2;

    //the following is controlling light color
    public GameObject greenLightBeam;
    private Color originalGreenLightBeamColor;
    private GameObject greenLightBeamPart1_1;
    private GameObject greenLightBeamPart1_2;
    private GameObject greenLightBeamPart1_3;
    private GameObject greenLightBeamPart2;


    public GameObject blueLightBeam;
    private Color originalBlueLightBeamColor;
    private GameObject blueLightBeamPart1_1;
    private GameObject blueLightBeamPart1_2;
    private GameObject blueLightBeamPart1_3;
    private GameObject blueLightBeamPart2;


    public GameObject redLightBeam;
    private Color originalRedLightBeamColor;
    private GameObject redLightBeamPart1_1;
    private GameObject redLightBeamPart1_2;
    private GameObject redLightBeamPart1_3;
    private GameObject redLightBeamPart2;

    public GameObject leftLightBeam;
    private Color originalLeftLightBeamColor;
    private GameObject leftLightBeamPart1_1;
    private GameObject leftLightBeamPart1_2;
    private GameObject leftLightBeamPart1_3;
    private GameObject leftLightBeamPart2;

    public GameObject rightLightBeam;
    private Color originalRightLightBeamColor;
    private GameObject rightLightBeamPart1_1;
    private GameObject rightLightBeamPart1_2;
    private GameObject rightLightBeamPart1_3;
    private GameObject rightLightBeamPart2;

    public GameObject leftLightBeam2;
    private Color originalLeftLightBeam2Color;
    private GameObject leftLightBeam2Part1_1;
    private GameObject leftLightBeam2Part1_2;
    private GameObject leftLightBeam2Part1_3;
    private GameObject leftLightBeam2Part2;

    public GameObject rightLightBeam2;
    private Color originalRightLightBeam2Color;
    private GameObject rightLightBeam2Part1_1;
    private GameObject rightLightBeam2Part1_2;
    private GameObject rightLightBeam2Part1_3;
    private GameObject rightLightBeam2Part2;

    public Image lightDot;
    public Image itemImage;

    // Store the original scales
    private Vector3 originalScalePart1_2;
    private Vector3 originalScalePart1_3;
    private Vector3 originalScalePart2;

    public float A1
    {
        get { return a1; }
    }

    public float A2
    {
        get { return a2; }
    }

    public float A3
    {
        get { return a3; }
    }

    public float A4
    {
        get { return a4; }
    }

    public float A5
    {
        get { return a5; }
    }

    public float A6
    {
        get { return a6; }
    }

    public float A7
    {
        get { return a7; }
    }


    // Start is called before the first frame update
    void Start()
    {
        GameObject filmGameObject11 = GameObject.Find("PolarizingFilm_1_1");
        film11 = filmGameObject11.GetComponent<PolarizingFilm>();
        GameObject button11 = filmGameObject11.transform.Find("ButtonSweetness").gameObject;
        buttonSweetness = button11.GetComponent<Button>();

        GameObject filmGameObject12 = GameObject.Find("PolarizingFilm_1_2");
        film12 = filmGameObject12.GetComponent<PolarizingFilm>();
        GameObject button12 = filmGameObject12.transform.Find("ButtonSalinity").gameObject;
        buttonSalinity = button12.GetComponent<Button>();

        GameObject filmGameObject13 = GameObject.Find("PolarizingFilm_1_3");
        film13 = filmGameObject13.GetComponent<PolarizingFilm>();
        GameObject button13 = filmGameObject13.transform.Find("ButtonGreasiness").gameObject;
        buttonGreasiness = button13.GetComponent<Button>();

        GameObject filmGameObject14 = extraPathLeft1.transform.Find("PolarizingFilm_1_4").gameObject;
        film14 = filmGameObject14.GetComponent<PolarizingFilm>();
        GameObject button14 = filmGameObject14.transform.Find("ButtonLeft1").gameObject;
        buttonLeft1 = button14.GetComponent<Button>();

        GameObject filmGameObject15 = extraPathRight1.transform.Find("PolarizingFilm_1_5").gameObject;
        film15 = filmGameObject15.GetComponent<PolarizingFilm>();
        GameObject button15 = filmGameObject15.transform.Find("ButtonRight1").gameObject;
        buttonRight1 = button15.GetComponent<Button>();

        GameObject filmGameObject16 = extraPathLeft2.transform.Find("PolarizingFilm_1_6").gameObject;
        film16 = filmGameObject16.GetComponent<PolarizingFilm>();
        GameObject button16 = filmGameObject16.transform.Find("ButtonLeft2").gameObject;
        buttonLeft2 = button16.GetComponent<Button>();

        GameObject filmGameObject17 = extraPathRight2.transform.Find("PolarizingFilm_1_7").gameObject;
        film17 = filmGameObject17.GetComponent<PolarizingFilm>();
        GameObject button17 = filmGameObject17.transform.Find("ButtonRight2").gameObject;
        buttonRight2 = button17.GetComponent<Button>();

        GameObject filmGameObject21 = GameObject.Find("PolarizingFilm_2_1");
        film21 = filmGameObject21.GetComponent<PolarizingFilm>();

        GameObject filmGameObject22 = GameObject.Find("PolarizingFilm_2_2");
        film22 = filmGameObject22.GetComponent<PolarizingFilm>();

        GameObject filmGameObject23 = GameObject.Find("PolarizingFilm_2_3");
        film23 = filmGameObject23.GetComponent<PolarizingFilm>();

        GameObject filmGameObject24 = extraPathLeft1.transform.Find("PolarizingFilm_2_4").gameObject;
        film24 = filmGameObject24.GetComponent<PolarizingFilm>();

        GameObject filmGameObject25 = extraPathRight1.transform.Find("PolarizingFilm_2_5").gameObject;
        film25 = filmGameObject25.GetComponent<PolarizingFilm>();

        GameObject filmGameObject26 = extraPathLeft2.transform.Find("PolarizingFilm_2_6").gameObject;
        film26 = filmGameObject26.GetComponent<PolarizingFilm>();

        GameObject filmGameObject27 = extraPathRight2.transform.Find("PolarizingFilm_2_7").gameObject;
        film27 = filmGameObject27.GetComponent<PolarizingFilm>();

        //the following is controlling light color change
        greenLightBeamPart1_1 = greenLightBeam.transform.Find("LightBeam_Part1-1").gameObject;
        greenLightBeamPart1_2 = greenLightBeam.transform.Find("LightBeam_Part1-2").gameObject;
        greenLightBeamPart1_3 = greenLightBeam.transform.Find("LightBeam_Part1-3").gameObject;
        greenLightBeamPart2 = greenLightBeam.transform.Find("LightBeam_Part2").gameObject;
        originalGreenLightBeamColor = greenLightBeamPart1_1.GetComponent<Renderer>().material.color;

        blueLightBeamPart1_1 = blueLightBeam.transform.Find("LightBeam_Part1-1").gameObject;
        blueLightBeamPart1_2 = blueLightBeam.transform.Find("LightBeam_Part1-2").gameObject;
        blueLightBeamPart1_3 = blueLightBeam.transform.Find("LightBeam_Part1-3").gameObject;
        blueLightBeamPart2 = blueLightBeam.transform.Find("LightBeam_Part2").gameObject;
        originalBlueLightBeamColor = blueLightBeamPart1_1.GetComponent<Renderer>().material.color;

        redLightBeamPart1_1 = redLightBeam.transform.Find("LightBeam_Part1-1").gameObject;
        redLightBeamPart1_2 = redLightBeam.transform.Find("LightBeam_Part1-2").gameObject;
        redLightBeamPart1_3 = redLightBeam.transform.Find("LightBeam_Part1-3").gameObject;
        redLightBeamPart2 = redLightBeam.transform.Find("LightBeam_Part2").gameObject;
        originalRedLightBeamColor = redLightBeamPart1_1.GetComponent<Renderer>().material.color;

        leftLightBeamPart1_1 = leftLightBeam.transform.Find("LightBeam_Part1-1").gameObject;
        leftLightBeamPart1_2 = leftLightBeam.transform.Find("LightBeam_Part1-2").gameObject;
        leftLightBeamPart1_3 = leftLightBeam.transform.Find("LightBeam_Part1-3").gameObject;
        leftLightBeamPart2 = leftLightBeam.transform.Find("LightBeam_Part2").gameObject;
        originalLeftLightBeamColor = leftLightBeamPart1_1.GetComponent<Renderer>().material.color;

        rightLightBeamPart1_1 = rightLightBeam.transform.Find("LightBeam_Part1-1").gameObject;
        rightLightBeamPart1_2 = rightLightBeam.transform.Find("LightBeam_Part1-2").gameObject;
        rightLightBeamPart1_3 = rightLightBeam.transform.Find("LightBeam_Part1-3").gameObject;
        rightLightBeamPart2 = rightLightBeam.transform.Find("LightBeam_Part2").gameObject;
        originalRightLightBeamColor = rightLightBeamPart1_1.GetComponent<Renderer>().material.color;

        leftLightBeam2Part1_1 = leftLightBeam2.transform.Find("LightBeam_Part1-1").gameObject;
        leftLightBeam2Part1_2 = leftLightBeam2.transform.Find("LightBeam_Part1-2").gameObject;
        leftLightBeam2Part1_3 = leftLightBeam2.transform.Find("LightBeam_Part1-3").gameObject;
        leftLightBeam2Part2 = leftLightBeam2.transform.Find("LightBeam_Part2").gameObject;
        originalLeftLightBeam2Color = leftLightBeam2Part1_1.GetComponent<Renderer>().material.color;

        rightLightBeam2Part1_1 = rightLightBeam2.transform.Find("LightBeam_Part1-1").gameObject;
        rightLightBeam2Part1_2 = rightLightBeam2.transform.Find("LightBeam_Part1-2").gameObject;
        rightLightBeam2Part1_3 = rightLightBeam2.transform.Find("LightBeam_Part1-3").gameObject;
        rightLightBeam2Part2 = rightLightBeam2.transform.Find("LightBeam_Part2").gameObject;
        originalRightLightBeam2Color = rightLightBeam2Part1_1.GetComponent<Renderer>().material.color;

        //the following is controlling the scale
        // Cache the original scales of the parts
        originalScalePart1_2 = greenLightBeamPart1_2.transform.localScale;
        originalScalePart1_3 = greenLightBeamPart1_3.transform.localScale;
        originalScalePart2 = greenLightBeamPart2.transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonSweetness.lightBeam.activeSelf)
        {
            a1 = film11.Value;
        }
        else { a1 = 0; }
        if (buttonSalinity.lightBeam.activeSelf)
        {
            a2 = film12.Value;
        }
        else { a2 = 0; }
        if (buttonGreasiness.lightBeam.activeSelf)
        {
            a3 = film13.Value;
        }
        else { a3 = 0; }
        if (extraPathLeft1.activeSelf && buttonLeft1.lightBeam.activeSelf)
        {
            a4 = film14.Value;
        }
        else { a4 = 0; }
        if (extraPathRight1.activeSelf && buttonRight1.lightBeam.activeSelf)
        {
            a5 = film15.Value;
        }
        else { a5 = 0; }
        if (extraPathLeft2.activeSelf && buttonLeft2.lightBeam.activeSelf)
        {
            a6 = film16.Value;
        }
        else { a6 = 0; }
        if (extraPathRight2.activeSelf && buttonRight2.lightBeam.activeSelf)
        {
            a7 = film17.Value;
        }
        else { a7 = 0; }

        b1 = film21.Value;
        b2 = film22.Value;
        b3 = film23.Value;
        if (extraPathLeft1.activeSelf)
        {
            b4 = film24.Value;
        }
        else { b4 = 0; }
        if (extraPathRight1.activeSelf)
        {
            b5 = film25.Value;
        }
        else { b5 = 0; }
        if (extraPathLeft2.activeSelf)
        {
            b6 = film26.Value;
        }
        else { b6 = 0; }
        if (extraPathRight2.activeSelf)
        {
            b7 = film27.Value;
        }
        else { b7 = 0; }
        value = DotProduct(a1, a2, a3, a4, a5, a6, a7, b1, b2, b3, b4, b5, b6, b7);
        text.GetComponent<TextMeshPro>().text = value.ToString("F2");
        float alpha = value * 255 / 300;
        text.GetComponent<TextMeshPro>().faceColor = new Color32(225, 135, 0, Convert.ToByte(alpha));

        // Change color of individual LightBeam_Part1-2 based on values
        ChangeLightBeamColor(greenLightBeamPart1_2, originalGreenLightBeamColor, a1);
        ChangeLightBeamColor(blueLightBeamPart1_2, originalBlueLightBeamColor, a2);
        ChangeLightBeamColor(redLightBeamPart1_2, originalRedLightBeamColor, a3);
        ChangeLightBeamColor(leftLightBeamPart1_2, originalLeftLightBeamColor, a4);
        ChangeLightBeamColor(rightLightBeamPart1_2, originalRightLightBeamColor, a5);
        ChangeLightBeamColor(leftLightBeam2Part1_2, originalLeftLightBeam2Color, a6);
        ChangeLightBeamColor(rightLightBeam2Part1_2, originalRightLightBeam2Color, a7);

        //Change color of LightBeam_Part1-3 and LightBeam_Part2 based on the product of values
        ChangeLightBeamColor(greenLightBeamPart1_3, originalGreenLightBeamColor, (a1) * (b1));
        ChangeLightBeamColor(blueLightBeamPart1_3, originalBlueLightBeamColor, (a2) * (b2));
        ChangeLightBeamColor(redLightBeamPart1_3, originalRedLightBeamColor, (a3) * (b3));
        ChangeLightBeamColor(leftLightBeamPart1_3, originalLeftLightBeamColor, (a4) * (b4));
        ChangeLightBeamColor(rightLightBeamPart1_3, originalRightLightBeamColor, (a5) * (b5));
        ChangeLightBeamColor(leftLightBeam2Part1_3, originalLeftLightBeam2Color, (a6) * (b6));
        ChangeLightBeamColor(rightLightBeam2Part1_3, originalRightLightBeam2Color, (a7) * (b7));
        ChangeLightBeamColor(greenLightBeamPart2, originalGreenLightBeamColor, (a1) * (b1));
        ChangeLightBeamColor(blueLightBeamPart2, originalBlueLightBeamColor, (a2) * (b2));
        ChangeLightBeamColor(redLightBeamPart2, originalRedLightBeamColor, (a3) * (b3));
        ChangeLightBeamColor(leftLightBeamPart2, originalLeftLightBeamColor, (a4) * (b4));
        ChangeLightBeamColor(rightLightBeamPart2, originalRightLightBeamColor, (a5) * (b5));
        ChangeLightBeamColor(leftLightBeam2Part2, originalLeftLightBeam2Color, (a6) * (b6));
        ChangeLightBeamColor(rightLightBeam2Part2, originalRightLightBeam2Color, (a7) * (b7));


        //the following is controlling the scale
        //Calculate new diameters based on a1, a2, a3 values for Part1_2
        float newDiameterGreenPart1_2 = CalculateNewDiameter(a1, originalScalePart1_2.x);
        float newDiameterBluePart1_2 = CalculateNewDiameter(a2, originalScalePart1_2.x);
        float newDiameterRedPart1_2 = CalculateNewDiameter(a3, originalScalePart1_2.x);
        float newDiameterLeft1Part1_2 = CalculateNewDiameter(a4, originalScalePart1_2.x);
        float newDiameterRight1Part1_2 = CalculateNewDiameter(a5, originalScalePart1_2.x);
        float newDiameterLeft2Part1_2 = CalculateNewDiameter(a6, originalScalePart1_2.x);
        float newDiameterRight2Part1_2 = CalculateNewDiameter(a7, originalScalePart1_2.x);


        // Calculate new diameters based on a1, a2, a3 * b1, b2, b3 values for Part1_3 and Part2
        float newDiameterGreenPart1_3 = CalculateNewDiameter((a1) * (b1), originalScalePart1_3.x);
        float newDiameterBluePart1_3 = CalculateNewDiameter((a2) * (b2), originalScalePart1_3.x);
        float newDiameterRedPart1_3 = CalculateNewDiameter((a3) * (b3), originalScalePart1_3.x);
        float newDiameterLeft1Part1_3 = CalculateNewDiameter((a4) * (b4), originalScalePart1_3.x);
        float newDiameterRight1Part1_3 = CalculateNewDiameter((a5) * (b5), originalScalePart1_3.x);
        float newDiameterLeft2Part1_3 = CalculateNewDiameter((a6) * (b6), originalScalePart1_3.x);
        float newDiameterRight2Part1_3 = CalculateNewDiameter((a7) * (b7), originalScalePart1_3.x);


        // Apply the new diameters to the respective cylinders
        UpdateCylinderDiameter(greenLightBeamPart1_2, newDiameterGreenPart1_2);
        UpdateCylinderDiameter(blueLightBeamPart1_2, newDiameterBluePart1_2);
        UpdateCylinderDiameter(redLightBeamPart1_2, newDiameterRedPart1_2);
        UpdateCylinderDiameter(leftLightBeamPart1_2, newDiameterLeft1Part1_2);
        UpdateCylinderDiameter(rightLightBeamPart1_2, newDiameterRight1Part1_2);
        UpdateCylinderDiameter(leftLightBeam2Part1_2, newDiameterLeft2Part1_2);
        UpdateCylinderDiameter(rightLightBeam2Part1_2, newDiameterRight2Part1_2);

        UpdateCylinderDiameter(greenLightBeamPart1_3, newDiameterGreenPart1_3);
        UpdateCylinderDiameter(blueLightBeamPart1_3, newDiameterBluePart1_3);
        UpdateCylinderDiameter(redLightBeamPart1_3, newDiameterRedPart1_3);
        UpdateCylinderDiameter(leftLightBeamPart1_3, newDiameterLeft1Part1_3);
        UpdateCylinderDiameter(rightLightBeamPart1_3, newDiameterRight1Part1_3);
        UpdateCylinderDiameter(leftLightBeam2Part1_3, newDiameterLeft2Part1_3);
        UpdateCylinderDiameter(rightLightBeam2Part1_3, newDiameterRight2Part1_3);


        UpdateConeBaseDiameter(greenLightBeamPart2, newDiameterGreenPart1_3);
        UpdateConeBaseDiameter(blueLightBeamPart2, newDiameterBluePart1_3);
        UpdateConeBaseDiameter(redLightBeamPart2, newDiameterRedPart1_3);
        UpdateConeBaseDiameter(leftLightBeamPart2, newDiameterLeft1Part1_3);
        UpdateConeBaseDiameter(rightLightBeamPart2, newDiameterRight1Part1_3);
        UpdateConeBaseDiameter(leftLightBeam2Part2, newDiameterLeft2Part1_3);
        UpdateConeBaseDiameter(rightLightBeam2Part2, newDiameterRight2Part1_3);

        // // Get the colors of the three LightBeamPart2
        // Color greenColorPart2 = greenLightBeamPart2.GetComponent<Renderer>().material.color;
        // Color blueColorPart2 = blueLightBeamPart2.GetComponent<Renderer>().material.color;
        // Color redColorPart2 = redLightBeamPart2.GetComponent<Renderer>().material.color;
        // Color lightdotColor = lightDot.color;
        // //change the color of lightdot - may need a more complex function
        // lightdotColor.a = Mathf.Min(1, Mathf.Max(0, greenColorPart2.a + blueColorPart2.a + redColorPart2.a - 0.3f));
        // lightDot.color = lightdotColor;
        // Color itemImageColor = itemImage.color;
        // itemImageColor.a = Mathf.Min(1, Mathf.Max(0, greenColorPart2.a + blueColorPart2.a + redColorPart2.a - 0.3f));
        // itemImage.color = itemImageColor;

        // Get the colors of the seven LightBeamPart2
        Color greenColorPart2 = greenLightBeamPart2.GetComponent<Renderer>().material.color;
        Color blueColorPart2 = blueLightBeamPart2.GetComponent<Renderer>().material.color;
        Color redColorPart2 = redLightBeamPart2.GetComponent<Renderer>().material.color;
        Color left1ColorPart2 = leftLightBeamPart2.GetComponent<Renderer>().material.color;
        Color right1ColorPart2 = rightLightBeamPart2.GetComponent<Renderer>().material.color;
        Color left2ColorPart2 = leftLightBeam2Part2.GetComponent<Renderer>().material.color;
        Color right2ColorPart2 = rightLightBeam2Part2.GetComponent<Renderer>().material.color;

        Color lightdotColor = lightDot.color;
        Color itemImageColor = itemImage.color;

        // if(isChallenge1){
        //     lightdotColor.a = Mathf.Min(1, Mathf.Max(0, greenColorPart2.a + blueColorPart2.a + redColorPart2.a + left1ColorPart2.a - 0.1f));
        //     lightDot.color = lightdotColor;
        //     itemImageColor.a = Mathf.Min(1, Mathf.Max(0, greenColorPart2.a + blueColorPart2.a + redColorPart2.a + left1ColorPart2.a - 0.1f));
        //     itemImage.color = itemImageColor;
        // }else {
        //     // Calculate the average alpha value
        //     float totalAlpha = greenColorPart2.a + blueColorPart2.a + redColorPart2.a +
        //                     left1ColorPart2.a + right1ColorPart2.a + left2ColorPart2.a + right2ColorPart2.a;
        //     float averageAlpha = totalAlpha / 3.2f;

        //     // Clamp the average alpha value
        //     //float clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha - 0.3f));
        //     float clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha));

        //     // Change the color of lightDot
        //     //Color lightdotColor = lightDot.color;
        //     lightdotColor.a = clampedAlpha;
        //     lightDot.color = lightdotColor;

        //     // Change the color of itemImage
        //     //Color itemImageColor = itemImage.color;
        //     itemImageColor.a = clampedAlpha;
        //     itemImage.color = itemImageColor;
        // }
        float totalAlpha = greenColorPart2.a + blueColorPart2.a + redColorPart2.a +
                            left1ColorPart2.a + right1ColorPart2.a + left2ColorPart2.a + right2ColorPart2.a;
        float averageAlpha = totalAlpha / 3.2f;
        float clampedAlpha = 0f;
        if (averageAlpha < 0.1f)
        {
            clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha));
        }
        else
        {
            clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha + 0.4f));
        }

        // Clamp the average alpha value
        //float clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha - 0.3f));
        //float clampedAlpha = Mathf.Min(1, Mathf.Max(0, averageAlpha + 0.3f));

        // Change the color of lightDot
        //Color lightdotColor = lightDot.color;
        lightdotColor.a = clampedAlpha;
        lightDot.color = lightdotColor;

        // Change the color of itemImage
        //Color itemImageColor = itemImage.color;
        itemImageColor.a = clampedAlpha;
        itemImage.color = itemImageColor;

        // Debug.Log("value: " + value + " alpha: " + alpha + " clamped alpha: " + clampedAlpha);
        lightdotColor.a = Mathf.Min(1, value / 2.0f);
    }

    private float DotProduct(float a1, float a2, float a3, float a4, float a5, float a6, float a7, float b1, float b2, float b3, float b4, float b5, float b6, float b7)
    {
        float result = (a1 * b1 + a2 * b2 + a3 * b3 + a4 * b4 + a5 * b5 + a6 * b6 + a7 * b7);
        return result;
    }

    private void ChangeLightBeamColor(GameObject lightBeamPart, Color originalColor, float percentage)
    {
        percentage = Mathf.Clamp01(percentage);
        Color newColor = originalColor;
        newColor.a *= percentage;
        lightBeamPart.GetComponent<Renderer>().material.color = newColor;
    }

    float CalculateNewDiameter(float percentage, float originalDiameter)
    {
        // Ensure percentage is within bounds
        percentage = Mathf.Clamp01(percentage);

        // Calculate the new diameter based on the desired area
        float originalRadius = originalDiameter / 2f;
        float originalArea = Mathf.PI * originalRadius * originalRadius;
        float newArea = percentage * originalArea;
        float newRadius = Mathf.Sqrt(newArea / Mathf.PI);
        float newDiameter = 2f * newRadius;

        return newDiameter;
    }

    void UpdateCylinderDiameter(GameObject cylinder, float newDiameter)
    {
        // Adjust the scale based on the new diameter
        Vector3 newScale = cylinder.transform.localScale;
        newScale.x = newDiameter;
        newScale.z = newDiameter; // Assuming uniform scaling for the cylinder

        cylinder.transform.localScale = newScale;
    }

    void UpdateConeBaseDiameter(GameObject cone, float newDiameter)
    {
        // Adjust the scale based on the new diameter
        Vector3 newScale = cone.transform.localScale;
        newScale.x = newDiameter;

        cone.transform.localScale = newScale;
    }

}
