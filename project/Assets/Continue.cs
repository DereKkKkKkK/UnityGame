using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject panel;

    public void continuegame()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
    }
}
