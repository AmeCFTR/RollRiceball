using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Player
{
    public class MoveText : MonoBehaviour
    {
        public Text text;

        // Start is called before the first frame update
        void Start()
        {
            //transform.DOLocalMove(new Vector3(-341f, 303, 0), 2f).SetEase(Ease.InOutQuart); //シンプルな移動(ローカル)

            if (SceneController.isGameReady)
            {
                text.gameObject.SetActive(false);
            }

            text.DOFade(1, 0.000001f);
            transform.DOMoveX(380, 1.2f);
            text.DOFade(0, 1.2f);

        }

        // Update is called once per frame
        void Update()
        {
            if (GimmickUI.isGetText&&GimmickUI.Getcheck==1)
            {
                text.gameObject.SetActive(true);
                GimmickUI.Getcheck = 0;
            }
        }
    }
}
