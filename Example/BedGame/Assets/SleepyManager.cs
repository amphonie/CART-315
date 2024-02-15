using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SleepyManager : MonoBehaviour
{
    public GameObject sleepy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SleepySpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SleepySpawn()
    {
        float x = Random.Range(-8f, 8f);
        Instantiate(sleepy, new Vector3(x, 6, 0), quaternion.identity);
        
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SleepySpawn());

    }
}
