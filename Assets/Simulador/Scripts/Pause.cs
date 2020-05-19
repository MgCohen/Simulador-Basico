using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pause : MonoBehaviour
{
    public bool paused = false;
    public TextMeshProUGUI text;

    public void PauseSim()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
            text.text = "Continuar";
        }
        else
        {
            Time.timeScale = 1;
            text.text = "Pausar";
        }
    }
}
