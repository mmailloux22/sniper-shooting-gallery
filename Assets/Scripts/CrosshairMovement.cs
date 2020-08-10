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
}
