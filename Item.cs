using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Item : MonoBehaviour
    {
        public static int RiceConuter; //staticを付ける
        public static int RemoveRiceCounter;
        public static int ForCameraRiceCounter;
        public static int RiceBonus;

        void Awake()
        {
            gameObject.tag = ("Rice");
        }

    void Start()
    {

    }

        private void OnCollisionEnter(Collision hit)
        {
            if (hit.gameObject.CompareTag("Player"))
            {
                this.transform.parent = hit.gameObject.transform;
                gameObject.tag = ("Player");
                RiceConuter++;
                RemoveRiceCounter++;
                ForCameraRiceCounter++;

                /*  if (ForCameraRiceCounter >= 5)
                  {
                      ForCameraRiceCounter = 0;
                  }*/

                RiceBonus += 10;
                //Debug.Log(RiceConuter);
                // Debug.Log(RiceBonus);
                //GetComponent<BoxCollider>().enabled = false;
            }
        }
    }


