using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTree : MonoBehaviour
{
    public GameObject StageCube;
    public int StageCount = 25;
    public float x;
    public float y;
    int i = 0;
    float zChange = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (i = 0; i < StageCount; i++)
        {
            zChange += 7.0f;
            y -= 4.04f;
            Instantiate(StageCube, new Vector3(x, y, zChange), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


