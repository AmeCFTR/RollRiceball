using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class Toriniku : MonoBehaviour
    {
        GameManager gameManager;
        public static int ChickenCounter = 0;
        public Text BonusText;
        public int[] RandomBonusScore = new int[4] { 100, 150, 200,1000 };
        private int RmdCatch;

        void Start()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        /*void OnTriggerEnter(Collider other)
        {
            gameManager.Score += 100;
        }*/

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                RmdCatch = Random.Range(0, 101);
            if (RmdCatch >= 0 && RmdCatch <= 49) //50％ 0～50
            {
                gameManager.Score += RandomBonusScore[0];
                BonusText.text = "スコア+100";
            }
            else if (RmdCatch >= 50 && RmdCatch <= 79) //30％ 50～80
            {
                gameManager.Score += RandomBonusScore[1];
                BonusText.text = "スコア+150";
            }
            else if (RmdCatch >= 80 && RmdCatch <= 94) //15% 80～95
            {
                gameManager.Score += RandomBonusScore[2];
                BonusText.text = "スコア+200";
            }
            else if (RmdCatch >= 95 && RmdCatch <= 100) //5% 95～100
            {
                gameManager.Score += RandomBonusScore[3];
                BonusText.text = "スコア+1000";
            }
            // gameManager.Score += 100;
                ChickenCounter++;
                Destroy(this.gameObject);
            }
        }
    }

