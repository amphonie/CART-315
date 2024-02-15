using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BrickLayerManager : MonoBehaviour
{
    public GameObject brick;

    public int rows, columns;

    public float brickSpacing_h;

    public float brickSpacing_v;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                float xPos = -columns + (i * brickSpacing_h);
                float yPos = rows - (i * brickSpacing_v);
                Instantiate(brick, position: new Vector3(x: 0, y: 0, z: 0),quaternion.identity, this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
