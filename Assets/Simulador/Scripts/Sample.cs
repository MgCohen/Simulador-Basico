using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public float speed;
    public float infectionChance;


    public Rigidbody2D body;

    public Spawner spawner;

    public bool infected = false;

    private void Start()
    {
        var x = Random.Range(-1f, 1f);
        var y = Random.Range(-1f, 1f);
        var dir = new Vector2(x, y).normalized;
        body.velocity = dir * speed;
    }

    private void Update()
    {
        body.velocity = body.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (infected)
        {
            var s = collision.transform.GetComponent<Sample>();
            float r = Random.value;
            if (s && !s.infected && r <= infectionChance)
            {
                s.Infect();
            }
        }
    }

    public void Infect()
    {
        infected = true;
        GetComponent<SpriteRenderer>().color = Color.green;
        spawner.Healthy.Remove(this);
        spawner.Infected.Add(this);
    }


}
