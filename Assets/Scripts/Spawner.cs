using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject secretAgent;
    public GameObject civilian;
    public GameObject target;
    public float population;
    public float civilianPercent;
    public float targetPercent;
    public float secretAgentPercent;
    private int civilianAmount;
    private int targetAmount;
    private int secretAgentAmount;

    void Awake() 
    {
        population = 40;
        civilianAmount = (int) (civilianPercent / 100 * population);
        targetAmount = (int) (targetPercent / 100 * population);
        secretAgentAmount = (int) (secretAgentPercent / 100 * population);

        spawnSecretAgents();
        spawnCivilians();
        spawnTargets();

    }

    void spawnSecretAgents() 
    {
        for (int i = 0; i < secretAgentAmount; i++)
        {
            Instantiate(secretAgent, new Vector2(0, 0), Quaternion.identity);
        }
    }

    void spawnCivilians()
    {
        for (int i = 0; i < civilianAmount; i++)
        {
            Instantiate(civilian, new Vector2(0, 0), Quaternion.identity);
        }
    }

    void spawnTargets()
    {
        for (int i = 0; i < targetAmount; i++)
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
