using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class SphereController : MonoBehaviour {
        public float speed = 20; // 動く速さ 15～20

        private Rigidbody rb; // Rididbody

        public float MAX_Speed = 25; //最高速度 20～25

        private float SaveSpeed = 18;
        private float SaveMax_Speed = 20;

        private bool isSpeedReset = false;
        private bool hasWater = true;

        void Start() {
            // Rigidbody を取得
            rb = GetComponent<Rigidbody>();
            if (SceneController.isGameReady) {
                rb.constraints = RigidbodyConstraints.FreezePosition;
            }
        }

        void Update() {
            if (SceneController.isGameReady == false) {
                rb.constraints = RigidbodyConstraints.None;
            }
            // カーソルキーの入力を取得
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            // カーソルキーの入力に合わせて移動方向を設定
            var movement = new Vector3(moveHorizontal, 0, moveVertical);

            // Ridigbody に力を与えて玉を動かす
            if (rb.velocity.z <= MAX_Speed)
                rb.AddForce(movement * speed);
            else
                rb.AddForce(Vector3.back * 5);

            /*Debug.Log(speed);
            Debug.Log(MAX_Speed);

            Debug.Log(SaveMax_Speed);
            Debug.Log(SaveSpeed);
            Debug.Log(isWater);
            //Debug.Log(isSpeedReset);*/

        }


        private void OnCollisionEnter(Collision hit) {
            if (hit.gameObject.CompareTag("Toriniku")) {
                speed += 0.6f;
                MAX_Speed += 0.4f;
            }

            if (hit.gameObject.CompareTag("Floor") && isSpeedReset)  
            {
                speed = SaveSpeed - 1.0f;
                MAX_Speed = SaveMax_Speed - 1.0f;
                isSpeedReset = false;
                hasWater = true;
            }

            if (hit.gameObject.CompareTag("Water") && hasWater) {
                SaveSpeed = speed;
                SaveMax_Speed = MAX_Speed;

                speed = speed / 8;
                MAX_Speed = MAX_Speed / 5;
                hasWater = false;
                isSpeedReset = true;
            }
        }

        /*   private void OnTriggerEnter(Collider other)
           {
               if (other.gameObject.CompareTag("Water")&&isWater)
               {
                   SaveSpeed = speed;
                   SaveMax_Speed = MAX_Speed;

                   speed = speed / 2;
                   MAX_Speed = MAX_Speed / 2;
                   isWater = false;
                   isSpeedReset = true;
               }
           }

           /*   private void OnTriggerStay(Collider other)
              {
                  if (other.gameObject.CompareTag("Water")) //減速
                  {
                      speed = speed / 2;
                      MAX_Speed = MAX_Speed / 2;
                  }
              }*/
    }
}
