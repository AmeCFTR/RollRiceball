using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject UI_kigi;
    [SerializeField]
    public GameObject UI_player;
    [SerializeField]
    public GameObject Seaweed;
    [SerializeField]
    Text scoreText;
    [SerializeField]
    GameObject playerObj;
    public Vector3 positionKizi;
    public Vector3 position;

   // public Text DangerousText;

    public static int score = 0;
    public static float resultScore;
    public float EnhanceMagnification = 1.0f;
    public float PheasantSpeed=0.26f;

    int riceNum = 0;

    seaweed sea;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        positionKizi.y = 0;
        sea = Seaweed.GetComponent<seaweed>();
     //   DangerousText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneController.isGameReady == false)
        {
            positionKizi = UI_kigi.transform.position;
            //Debug.Log(positionKizi);
            positionKizi.y += PheasantSpeed; //キジ速度 0.19～0.26
            if (sea.canMove == false)
            {
                PheasantSpeed = 0;
            }

            UI_kigi.transform.position = positionKizi;

            position = UI_player.transform.position;
            //Debug.Log(position);
            position.y = playerObj.transform.position.z + 190; /*z=5で+100していたので105 開始と同時にゲームオーバーになる理由は、プレイヤーもキジも、
                                                                                  同じpositionという変数を使っていたから?*/
            UI_player.transform.position = position;

        /*  if (UI_player.transform.position.y - 20 <= UI_kigi.transform.position.y)
            {
                DangerousText.gameObject.SetActive(true);
            }
            else
            {
                DangerousText.gameObject.SetActive(false);
            }*/

            if (UI_player.transform.position.y <= UI_kigi.transform.position.y) //キジが御握りに追いついたら終了
            {
             //   Debug.Log(UI_player.transform.position.y);
             //   Debug.Log(UI_kigi.transform.position.y);
                SceneManager.LoadScene("GameOver");
            }
       
            score++;
            scoreText.text = "Score : " + (score*EnhanceMagnification).ToString("f0") + "\n米の数 : " + Item.RiceConuter/*playerObj.transform.childCount*/ + "粒"; //くっついた米粒はRiceBallの子オブジェクトになる 
            resultScore = (int)score * EnhanceMagnification;
        }
    }

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
}
