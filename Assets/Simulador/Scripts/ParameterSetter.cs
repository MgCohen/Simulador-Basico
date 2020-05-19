using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ParameterSetter : MonoBehaviour
{
    public bool isPercentage;
    public TextMeshProUGUI text;
    public TextMeshProUGUI title;

    public Slider slider;

    public string sliderName;
    public float minValue;
    public float maxValue;
    public bool wholeNumber;
    public float startingNumber;

    private void OnEnable()
    {
        title.text = sliderName;
        slider.minValue = minValue;
        slider.maxValue = maxValue;
        slider.wholeNumbers = wholeNumber;
        slider.value = startingNumber;
        slider.onValueChanged.Invoke(slider.value);
    }

    public void Set(float value)
    {
        text.text = (!isPercentage) ? value.ToString("F1") : value.ToString("F1") + "%";
    }
}
