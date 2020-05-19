using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    // Start is called before the first frame update
    //void Start()
    //{
    //    Spawn();
    //}

    public List<Sample> AllSamples = new List<Sample>();
    public List<Sample> Infected = new List<Sample>();
    public List<Sample> Healthy = new List<Sample>();


    public Parameters parameters;

    public Transform pivot;

    public float elapsedTime = 0;

    bool started = false;

    public void Spawn()
    {
        started = true;
        ClearLists();
        elapsedTime = 0;
        var bounds = pivot.GetBounds();
        var limitMin = bounds.center - (bounds.extents * 0.8f);
        var limitMax = bounds.center + (bounds.extents * 0.8f);
        var sampleScale = new Vector3(parameters.SampleSize, parameters.SampleSize, 1);
        for (int i = 0; i < parameters.Amount; i++)
        {
            var s = Instantiate(parameters.SampleObjct, transform).GetComponent<Sample>();
            s.transform.localScale = sampleScale;
            var x = Random.Range(limitMin.x, limitMax.x);
            var y = Random.Range(limitMin.y, limitMax.y);
            s.speed = parameters.Speed;
            s.spawner = this;
            s.infectionChance = parameters.infectionChance;
            s.transform.position = new Vector3(x, y, 0);
            AllSamples.Add(s);
            Healthy.Add(s);
        }

        for (int i = 0; i < parameters.infected; i++)
        {
            var s = Healthy[Random.Range(0, Healthy.Count)];
            s.Infect();
        }
    }

    public void ClearLists()
    {
        foreach (var s in AllSamples)
        {
            Destroy(s.gameObject);
        }
        AllSamples.Clear();
        Healthy.Clear();
        Infected.Clear();
    }

    private void Update()
    {
        if (started)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}
