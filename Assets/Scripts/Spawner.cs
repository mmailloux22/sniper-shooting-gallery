using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject secretAgent;
    public GameObject civilian;
    public GameObject target;
    Dictionary<string, List<GameObject>> people;
    public float population;
    public float civilianPercent;
    public float targetPercent;
    public float secretAgentPercent;
    private int civilianAmount;
    private int targetAmount;
    private int secretAgentAmount;
    private GameObject secretAgentClone;
    private GameObject civilianClone;
    private GameObject targetClone;

    void Awake() 
    {
        people = new Dictionary<string, List<GameObject>>();
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
            secretAgentClone = (GameObject) Instantiate(secretAgent, new Vector2(0, 0), Quaternion.identity);
            if (!people.ContainsKey("SecretAgent")) 
            {
                people.Add("SecretAgent", new List<GameObject>());
            }
            people["SecretAgent"].Add(secretAgentClone);
        }
    }

    void spawnCivilians()
    {
        for (int i = 0; i < civilianAmount; i++)
        {
            civilianClone = (GameObject) Instantiate(civilian, new Vector2(0, 0), Quaternion.identity);
            if (!people.ContainsKey("Civilian"))
            {
                people.Add("Civilian", new List<GameObject>());
            }
            people["Civilian"].Add(civilianClone);
        }
    }

    void spawnTargets()
    {
        for (int i = 0; i < targetAmount; i++)
        {
            targetClone = (GameObject) Instantiate(target, new Vector2(0, 0), Quaternion.identity);
            if (!people.ContainsKey("Target"))
            {
                people.Add("Target", new List<GameObject>());
            }
            people["Target"].Add(targetClone);
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
