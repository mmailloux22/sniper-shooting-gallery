using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{
    private Vector2 mousePosition;
    public float moveSpeed = 1f;

    void Awake() 
    {
        Cursor.visible = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    void OnTriggerStay2D(Collider2D col) 
    {
        //Collider2D[] colliders = new Collider2D[10];
        //ContactFilter2D contactFilter = new ContactFilter2D();
        //contactFilter = contactFilter.NoFilter();
        //col.OverlapCollider(contactFilter, colliders);
        //Debug.Log(col.name);
        if (col.name.Equals("secretagent(Clone)") && Input.GetMouseButton(0)) 
        {
            col.gameObject.SetActive(false);
        }
        else if (col.name.Equals("civilian(Clone)") && Input.GetMouseButton(0))
        {
            col.gameObject.SetActive(false);
        }
    }
}
