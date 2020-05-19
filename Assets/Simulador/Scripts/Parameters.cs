using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Parameters", menuName = "Parameters")]
public class Parameters : ScriptableObject
{

    public float Speed;
    [TextArea] public string speedDescription;

    public void SetSpeed(float newSpeed)
    {
        Speed = newSpeed;
    }

    public void GetSpeedInfo()
    {
        parameterName = "Velocidade";
        parameterDescription = speedDescription;
    }

    public float infectionChance;
    [TextArea] public string infctChanceDescription;

    public void SetInfectionChance(float newIf)
    {
        infectionChance = newIf / 100f;
    }

    public void GetIFInfo()
    {
        parameterName = "Chance de infecção";
        parameterDescription = infctChanceDescription;
    }

    public int Amount;
    [TextArea] public string amountDescription;

    public void SetAmount(float newAmount)
    {
        Amount = Mathf.RoundToInt(newAmount);
    }

    public void GetAmountInfo()
    {
        parameterName = "Quantidade";
        parameterDescription = amountDescription;
    }

    public int infected;
    [TextArea] public string infectedDescription;

    public void SetInfected(float newInfected)
    {
        infected = Mathf.RoundToInt(newInfected);
    }

    public void GeInfectedInfo()
    {
        parameterName = "Infectados";
        parameterDescription = infectedDescription;
    }

    public float SampleSize;
    [TextArea] public string sizeDescription;

    public void SetSize(float newSize)
    {

    }

    public void GetSizeInfo()
    {
        parameterName = "Tamanho";
        parameterDescription = sizeDescription;
    }

    public GameObject SampleObjct;

    public GameObject infoPop;

    public string parameterName;
    public string parameterDescription;

    public void SetPop()
    {
        infoPop.SetActive(true);
    }
}
