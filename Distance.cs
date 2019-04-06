using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class Distance : MonoBehaviour
    {
        GameManager gameManager;
        public Text DistanceText;
        public static float DistanceDifference; //距離ボーナス用
        private float PlayerPosition;
        private float PheasantPosition;
        private bool isDanger=false;
        public AudioClip audioClip;
        AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            PlayerPosition=gameManager.UI_player.transform.position.y;
            PheasantPosition = gameManager.UI_kigi.transform.position.y;
            isDanger = false;
            audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
            audioSource.clip = audioClip;

        }

        // Update is called once per frame
        void Update()
        {
            PlayerPosition = gameManager.UI_player.transform.position.y;
            PheasantPosition = gameManager.UI_kigi.transform.position.y;
            DistanceText.text = "キジとの差 : " + (PlayerPosition - PheasantPosition).ToString("f0")+ "m";

            DistanceDifference = PlayerPosition - PheasantPosition;
        if (DistanceDifference > 100)
        {
            DistanceDifference = 100;
        }

        if (PlayerPosition - PheasantPosition <= 20)
            {
                DistanceText.color = new Color(255f / 255f, 156f / 255, 156f / 255f);
                if (isDanger == false) {
                    audioSource.PlayOneShot(audioSource.clip);
                    isDanger = true;
                    }
            }
            else
            {
                DistanceText.color = new Color(255f, 255f, 255f);
                isDanger = false;
            }
        }
    }

