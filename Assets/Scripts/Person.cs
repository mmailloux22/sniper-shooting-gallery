using UnityEngine;
using System.Collections;

public abstract class Person : MonoBehaviour,IPerson
{
    private Vector2 moveSpot;
    public GameObject personObject;
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
        spawn();
    }


    public void spawn()
    {
        if (!personObject.activeInHierarchy)
        {
            personObject.SetActive(true);
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
        personObject.SetActive(false);
    }

}
