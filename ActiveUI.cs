using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveUI : MonoBehaviour
{
    public Text returnText;
    // Start is called before the first frame update
    void Start()
    {
        returnText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("appearText", 4.5f);
    }

    private void appearText()
    {
        returnText.gameObject.SetActive(true);
    }
}
