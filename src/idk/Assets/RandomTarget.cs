using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour
{
    
    public int target_amount = 3;
    public Transform target;

    private int x, y;


    void SpawnRandom()
    {
        x = Random.Range(-1, 3);
        y = Random.Range(1, 3);
        Instantiate(target, new Vector3(x, y, 2), target.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnRandom();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
