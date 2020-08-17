using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject secretAgent;
    public GameObject civilian;
    public GameObject target;
    void Awake() 
    {
        for (int i = 0; i < 5;i++)
        {
            Instantiate(secretAgent, new Vector2(0, 0), Quaternion.identity);
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(civilian, new Vector2(0, 0), Quaternion.identity);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(target, new Vector2(0, 0), Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
