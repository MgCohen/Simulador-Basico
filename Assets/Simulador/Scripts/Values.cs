using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Values : MonoBehaviour
{
    public Spawner spawner;

    public TextMeshProUGUI infectedCount;
    public TextMeshProUGUI healthyCount;
    public TextMeshProUGUI elapsedTime;


    private void Update()
    {
        infectedCount.text = spawner.Infected.Count.ToString();
        healthyCount.text = spawner.Healthy.Count.ToString();
        elapsedTime.text = spawner.elapsedTime.ToString("F1");
    }

}
