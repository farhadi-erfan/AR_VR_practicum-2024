// 
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class PolarizingFilm : MonoBehaviour
{
    public bool interactable = true;
    public GameObject canvasObject;
    public Button button;
    public TMP_InputField inputField; // Add a reference to the input field
    //private GameObject inputFieldGameObject;
    private float _value; // value for level of taste

    public Transform typeOfTaste;
    public Transform typeOfTaste2;

    public Transform text;

    public GameObject slider;

    public Slider sliderInteractable;

    public float Value //the number
    {
        get { return _value; }
        set { _value = value; }
    }

    private Coroutine sliderDisappearCoroutine;
    private float sliderDisappearDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        SetValue(_value);

        if (interactable)
        {



            button.AddPointerDownUpListener(() =>
            {
                ResetSliderTimer(); // Reset timer when button is clicked
                DestroySlider();
                AddSlider();
                sliderInteractable.onValueChanged.AddListener(delegate
                {
                    _value = sliderInteractable.value;
                    SetValue(_value);
                    string typeOfTasteText = typeOfTaste.GetComponent<TextMeshPro>().text;
                    slider.transform.Find("Text").GetComponent<TextMeshProUGUI>().SetText($"{typeOfTasteText} = {_value}");
                    ResetSliderTimer();// Reset timer when button is clicked
                });
            });

            button.AddLongPressListener(() =>
            {
                //ResetSliderTimer(); // Reset timer when button is clicked
                // Show the input field and set its text to the current typeOfTaste
                inputField.gameObject.SetActive(true);
                inputField.text = typeOfTaste.GetComponent<TextMeshPro>().text;
                inputField.onEndEdit.AddListener(UpdateTypeOfTaste);
            });
        }
        StartSliderDisappearTimer();
    }

    void Update()
    {
        // Example: Check for user interaction to reset timer
        if (Input.GetMouseButtonDown(0) && slider != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePosition), Vector2.zero);

            // Check if user interacts with slider or its UI components
            if (hit.collider != null && hit.collider.gameObject == slider)
            {
                ResetSliderTimer(); // Reset timer when user interacts with slider
            }
        }
    }

    private void StartSliderDisappearTimer()
    {
        // Start coroutine to hide slider after delay
        sliderDisappearCoroutine = StartCoroutine(SliderDisappearCoroutine());
    }

    private void ResetSliderTimer()
    {
        // Reset or restart coroutine if slider exists
        if (sliderDisappearCoroutine != null)
        {
            StopCoroutine(sliderDisappearCoroutine);
        }
        sliderDisappearCoroutine = StartCoroutine(SliderDisappearCoroutine());
    }

    private IEnumerator SliderDisappearCoroutine()
    {
        yield return new WaitForSeconds(sliderDisappearDelay);

        // Destroy slider if it exists after delay
        if (slider != null)
        {
            DestroySlider();
        }

        // Optionally, hide the input field after the delay
        // if you want to hide the input field after the delay, uncomment the next line
        // inputField.gameObject.SetActive(false);
    }

    private void AddSlider()
    {
        var slider2D = Resources.Load<GameObject>("Slider2D");
        slider = Instantiate(slider2D, new Vector3(-600f, -175f, 0.0f), Quaternion.identity);
        slider.transform.SetParent(canvasObject.transform, false);
        sliderInteractable = slider.GetComponent<Slider>();
        sliderInteractable.value = _value;
        string typeOfTasteText = typeOfTaste.GetComponent<TextMeshPro>().text;
        slider.transform.Find("Text").GetComponent<TextMeshProUGUI>().SetText($"{typeOfTasteText} = {_value}");
    }

    private void DestroySlider()
    {
        slider = GameObject.Find("Slider2D(Clone)");
        if (slider != null)
        {
            GameObject.Destroy(slider);
        }
    }

    public void ValueChangeCheck()
    {
        Debug.Log(sliderInteractable.value);
    }

    public void SetValue(float value)
    {
        text.GetComponent<TextMeshPro>().text = value.ToString();
    }

    private void UpdateTypeOfTaste(string newText)
    {
        typeOfTaste.GetComponent<TextMeshPro>().text = newText;
        // Check if typeOfTaste2 is assigned
        if (typeOfTaste2 != null)
        {
            typeOfTaste2.GetComponent<TextMeshPro>().text = newText + " 2";
        }
        // Keep the input field active for further edits
        inputField.gameObject.SetActive(false); // Hide the input field after editing
        inputField.onEndEdit.RemoveListener(UpdateTypeOfTaste); // Remove the listener to prevent multiple additions
    }

}
