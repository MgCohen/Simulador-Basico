using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUp : MonoBehaviour
{

    private void Awake()
    {
        parameters.infoPop = gameObject;
        parameters.infoPop.SetActive(false);
    }
    public TextMeshProUGUI title;

    public TextMeshProUGUI text;


    public Parameters parameters;

    private void OnEnable()
    {
        title.text = parameters.parameterName;
        text.text = parameters.parameterDescription;
    }
}
