using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Player {
    public class GimmickUI : MonoBehaviour {
        public Text SpeedUpText;
        public Text SpeedDownText;
        public Text EnhanceMagText;
        public Text GetText;
        public static bool isGetText = false;
        public static int Getcheck = 1;
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

            if (collision.gameObject.CompareTag("Rice"))
            {
                if (Getcheck == 1)
                {
                    isGetText = true;
                }
                var InstText = Instantiate(GetText, new Vector3(365,707.5f,0), Quaternion.identity);
                InstText.transform.parent = GetText.transform.parent; //生成したテキストはGetTextの子オブジェクトに
            }
        }

        private void DisappearText() {
            SpeedUpText.gameObject.SetActive(false);
            SpeedDownText.gameObject.SetActive(false);
            EnhanceMagText.gameObject.SetActive(false);
        }
    }
}
