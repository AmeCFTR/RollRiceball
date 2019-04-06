using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class ChangeScale : MonoBehaviour {
        public GameObject RiceBall;
        public int BallClass = 1;
        public float RotateY = 10;
        public float RotateZ = 30;
        GameManager gameManager;
        Item item;
        
        // Start is called before the first frame update
        void Start() {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            item = GetComponent<Item>();
            BallClass = 1;
        }

        // Update is called once per frame
        void Update() {
            /*
             foreach (Transform child in transform){
    　　      GameObject.Destroy (child.gameObject);
    　       }
            　if(child.name == "object_hoge"){
          }

             */
            transform.Rotate(new Vector3(0, RotateY, RotateZ) * Time.deltaTime, Space.World);

            if (Item.RiceConuter >= 5) {
                this.transform.localScale = new Vector3(125, 125, 125);
                BallClass = 1;
            }

            if (Item.RiceConuter >= 10) {
                this.transform.localScale = new Vector3(140, 140, 140);
            }

            if (Item.RiceConuter >= 15) {
                this.transform.localScale = new Vector3(145, 145, 145);
            }

            if (Item.RiceConuter >= 20) {
                this.transform.localScale = new Vector3(150, 150, 150);
            }

            if (Item.RiceConuter >= 25) {
                this.transform.localScale = new Vector3(155, 155, 155);
            }

            if (Item.RiceConuter >= 30) {
                this.transform.localScale = new Vector3(170, 170, 170);
                BallClass = 2;
            }

            if (Item.RiceConuter >= 35) {
                this.transform.localScale = new Vector3(175, 175, 175);
            }

            if (Item.RiceConuter >= 40) {
                this.transform.localScale = new Vector3(180, 180, 180);    
            }

            if (Item.RiceConuter >= 45) {
                this.transform.localScale = new Vector3(185, 185, 185);
            }

            if (Item.RiceConuter >= 50) {
                this.transform.localScale = new Vector3(190, 190, 190);
                BallClass = 3;
            }

            if (Item.RiceConuter >= 55) {
                this.transform.localScale = new Vector3(195, 195, 195);
            }

            if (Item.RiceConuter >= 60) {
                this.transform.localScale = new Vector3(210, 210, 210);
            }

            if (Item.RiceConuter >= 65) {
                this.transform.localScale = new Vector3(215, 215, 215);
            }

            if (Item.RiceConuter >= 70) {
                this.transform.localScale = new Vector3(220, 220, 220);
            }

            if (Item.RiceConuter >= 80) {
                this.transform.localScale = new Vector3(230, 230, 230);
            }

            if (Item.RiceConuter >= 85) {
                this.transform.localScale = new Vector3(235, 235, 235);
            }

            if (Item.RiceConuter >= 90) {
                this.transform.localScale = new Vector3(237, 237, 237);
            }

            if (Item.RiceConuter >= 100) {
                this.transform.localScale = new Vector3(250, 250, 250);
            }

            if (Item.RiceConuter >= 110) {
                this.transform.localScale = new Vector3(255, 255, 255);
            }

            if (Item.RiceConuter >= 120) {
                this.transform.localScale = new Vector3(270, 270, 270);
            }

            if (Item.RiceConuter >= 130) {
                this.transform.localScale = new Vector3(275, 275, 275);
            }

            if (Item.RiceConuter >= 140) {
                this.transform.localScale = new Vector3(280, 280, 280);
            }

            if (Item.RiceConuter >= 150) {
                this.transform.localScale = new Vector3(285, 285, 285);
            }

            if (Item.RiceConuter >= 160) {
                this.transform.localScale = new Vector3(290, 290, 290);
            }

            if (Item.RiceConuter >= 170) {
                this.transform.localScale = new Vector3(295, 295, 295);
            }

            if (Item.RiceConuter >= 180) {
                this.transform.localScale = new Vector3(300, 300, 300);
            }

            if (Item.RiceConuter >= 190) {
                this.transform.localScale = new Vector3(305, 305, 305);
            }

            if (Item.RiceConuter >= 200) {
                this.transform.localScale = new Vector3(310, 310, 310);
            }
        }
    }
}
