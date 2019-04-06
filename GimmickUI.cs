using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Player {
    public class GimmickUI : MonoBehaviour {
        public Text SpeedUpText;
        public Text SpeedDownText;
        public Text EnhanceMagText;
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.CompareTag("Toriniku")) {
                SpeedUpText.gameObject.SetActive(true);
                Invoke("DisappearText", 1.0f);
            } else if (collision.gameObject.CompareTag("Water")) {
                SpeedDownText.gameObject.SetActive(true);
                Invoke("DisappearText", 1.0f);

            } else if (collision.gameObject.CompareTag("Salmon")) {
                EnhanceMagText.gameObject.SetActive(true);
                Invoke("DisappearText", 1.0f);
            }
        }

        private void DisappearText() {
            SpeedUpText.gameObject.SetActive(false);
            SpeedDownText.gameObject.SetActive(false);
            EnhanceMagText.gameObject.SetActive(false);
        }
    }
}
