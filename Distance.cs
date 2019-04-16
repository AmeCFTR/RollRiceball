using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class Distance : MonoBehaviour
    {
        GameManager gameManager;
        public Text DistanceText;
        public Image DisImage;
        public static float DistanceDifference; //距離ボーナス用
        private float PlayerPosition;
        private float PheasantPosition;
        private bool isDanger=false;
        public AudioClip audioClip;
        AudioSource audioSource;
        public GameObject Seaweed;
        seaweed sea;

    // Start is called before the first frame update
    void Start()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            sea = Seaweed.GetComponent<seaweed>();
            PlayerPosition =gameManager.UI_player.transform.position.y;
            PheasantPosition = gameManager.UI_kigi.transform.position.y;
            isDanger = false;
            audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
            audioSource.clip = audioClip;
            DistanceText.gameObject.SetActive(true);
            DisImage.gameObject.SetActive(true);
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

        if (PlayerPosition - PheasantPosition <= 20) //距離差が20m未満になったらテキストを赤くする
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
        if (sea.canMove == false)
        {
            DistanceText.gameObject.SetActive(false);
            DisImage.gameObject.SetActive(false);
        }

        }
    }

