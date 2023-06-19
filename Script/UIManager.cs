using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    public void SetScoreText(string txt){
        if(ScoreText){
            ScoreText.text = txt;
        }
    }

    public void ShowGameOverPanel(bool isShow){
        //neu gameoverpanel khac null
        if(GameOverPanel){
            GameOverPanel.SetActive(isShow);
        }
    }
}
