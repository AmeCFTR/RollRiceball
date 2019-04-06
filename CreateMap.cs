using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Material materials;
    int i = 0;
    void Start()
    {
        float zPos = 0;
        i = 0;
        // Z位置を+1しながらマップを生成していく
        for (; zPos < 25; zPos++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(-0.4f, 0.9f, zPos-0.9f);
            this.GetComponent<Renderer>().material = materials;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
