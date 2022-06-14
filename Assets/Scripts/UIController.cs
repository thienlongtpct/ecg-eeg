using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    void Awake()
    {
        if (UIController.Instance == null)
        {
            UIController.Instance = this;
        }
        else if (UIController.Instance != this)
        {
            Destroy(UIController.Instance.gameObject);
            UIController.Instance = this;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("UI");
    }
}
