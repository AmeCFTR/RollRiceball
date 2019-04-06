using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewMap : MonoBehaviour
{
    public GameObject StageCube;
    public int StageCount=25;
    int i = 0;
    float zChange = 19;
    // Start is called before the first frame update
    void Start()
    {
        for (i = 0; i < StageCount; i++)
        {
            zChange += 10;
            Instantiate(StageCube, new Vector3(-0.2f, -21.5f, zChange), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
