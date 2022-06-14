using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMobile : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Home))
            {
                Application.Quit();
                return;
            }
            else if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
}
