using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    public GameObject[] panels;
    void Start()
    {
        foreach (GameObject panel in panels) {
            panel.SetActive(false);
        }
    }
    public void Dekarasyon()
    {
        panels[0].SetActive(true);
    }

    public void Koltuk()
    {
        panels[1].SetActive(true);
    }

    public void Masalar()
    {
        panels[2].SetActive(true);
    }

    public void Back()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }

}
