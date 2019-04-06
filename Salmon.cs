using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : MonoBehaviour
{ 
    GameManager gameManager;
    public static int SalmonCounter = 0;
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            gameManager.EnhanceMagnification *= 1.15f; //スコア倍率アップ
            SalmonCounter++;
            Destroy(this.gameObject);
        }
    }
}
