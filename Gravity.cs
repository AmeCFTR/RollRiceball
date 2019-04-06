using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class Gravity : MonoBehaviour {
        Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update() {
            if (SceneController.isGameReady) {
                rb.useGravity = false;
            } else {
                rb.useGravity = true;
            }
        }
    }
}
