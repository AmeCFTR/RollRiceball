using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraControll {
    public class LeaveFromRiceBall : MonoBehaviour {
        public Camera cam;
        // Start is called before the first frame update
        void Start() {
            cam = GetComponent<Camera>();
            cam.fieldOfView = 60f;
        }

        // Update is called once per frame
        void Update() {
            if (Item.ForCameraRiceCounter >= 10) {
                cam.fieldOfView += 4f; //3～6
                Item.ForCameraRiceCounter = 0;
            }
        }
    }
}
