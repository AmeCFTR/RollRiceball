using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseOption : MonoBehaviour
{
    public GameObject ChooseBGM;
    public GameObject ChooseSE;
    public Text BGMRegenerationText;
    public Text SERegenerationText;
    public static bool canRegenerationBGM;
    public static bool canRegenerationSE;
    // Start is called before the first frame update

    void Start()
    {
        canRegenerationBGM = true;
        canRegenerationSE = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChooseBGM.SetActive(true);
            ChooseSE.SetActive(false);
            BGMRegenerationText.gameObject.SetActive(true);
            SERegenerationText.gameObject.SetActive(false);
            canRegenerationBGM = true;
            canRegenerationSE = false;

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            ChooseBGM.SetActive(false);
            ChooseSE.SetActive(true);
            BGMRegenerationText.gameObject.SetActive(false);
            SERegenerationText.gameObject.SetActive(true);
            canRegenerationBGM = false;
            canRegenerationSE = true;
        }

    }
}
