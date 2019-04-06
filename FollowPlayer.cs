using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraControll {
    public class FollowPlayer : MonoBehaviour {
        [SerializeField]
        Transform target;
        Vector3 offset;

        void Start() {
            offset = GetComponent<Transform>().position - target.position;
        }

        void Update() {
            GetComponent<Transform>().position = target.position + offset;
        }
    }
}
