using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class RemoveRice : MonoBehaviour {
        // Start is called before the first frame update
        ChangeScale CS;
        void Start() {
            CS = GetComponent<ChangeScale>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Item.RemoveRiceCounter >= 15 && CS.BallClass == 1)
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                    Item.RemoveRiceCounter = 0;
                }
            }

            else if (Item.RemoveRiceCounter >= 25 && CS.BallClass == 2)
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                    Item.RemoveRiceCounter = 0;
                }
            }

            else if (Item.RemoveRiceCounter >= 50 && CS.BallClass == 3)
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                    Item.RemoveRiceCounter = 0;
                }
            }

        }
    }
}