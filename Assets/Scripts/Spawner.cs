using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int i = 0;
    public GameObject Enemy;
    public Transform Dummy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (i < 1000)
        {
            i++;
            Dummy.position = new Vector3(
                Random.Range(-10.0f, 10.0f),
                Random.Range(-10.0f, 10.0f),
                0);
            Instantiate(Enemy , Dummy);

        }
        
    }
}
