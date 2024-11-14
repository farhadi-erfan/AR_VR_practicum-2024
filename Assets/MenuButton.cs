using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{

    public void OnMenuButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}

