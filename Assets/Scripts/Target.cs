using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, Person
{
    private Vector2 moveSpot;
    public Transform tr;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float speed;

    void Awake()
    {
        moveSpot = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    void Update()
    {
        move();
    }

    public void spawn()
    {
        if (!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
            tr.position = Vector2.zero;
        }
    }

    public void move()
    {
        tr.position = Vector2.MoveTowards(tr.position, moveSpot, speed * Time.deltaTime);
        if (Vector2.Distance(tr.position, moveSpot) < 0.2f)
        {
            moveSpot = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }
    }

    public void die()
    {
        gameObject.SetActive(false);
    }
}
