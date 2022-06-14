using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorController : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;
    [SerializeField] Text patientName;
    int patientID = 0;
    [SerializeField] AudioSource BGM;
    public int PatientID { get => patientID; set => patientID = value; }
    void Start()
    {
        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Long");
        items.Add("Khanh");
        items.Add("Ivan");
        items.Add("Nikita");
        items.Add("Chumakov");

        foreach (var i in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = i });
        }

        dropdown.onValueChanged.AddListener(delegate { SelectPatient(dropdown); });
    }

    void SelectPatient(Dropdown dropdown)
    {
        int index = dropdown.value;
        patientName.text = dropdown.options[index].text;
        PatientID = index;
        dropdown.interactable = false;
    }

    public void PlayBGM()
    {
        BGM.Play();
    }

    public void Back()
    {
        UIController.Instance.BackToMainMenu();
    }
}
