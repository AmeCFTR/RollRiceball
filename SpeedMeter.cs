using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedMeter : MonoBehaviour
{
    public TextMeshProUGUI SpeedMeterText;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        SpeedMeterText.text = (rb.velocity.magnitude).ToString("f0");
    }
}
