using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    int m_score;
    public float spawnTime;
    float m_spawnTime;
    bool m_gameOver;
    UIManager m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("SCORE: "+ m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_gameOver){
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if (m_spawnTime <= 0){
            SpawnBall();
            m_spawnTime = spawnTime;
        }
    }
    public void Replay(){
        m_score = 0;
        m_gameOver = false;
        m_ui.SetScoreText("SCORE: "+ m_score);
        m_ui.ShowGameOverPanel(false);
    }
    public void SpawnBall(){
        Vector2 pos = new Vector2(Random.Range(-16,16),12);
        if (ball){
            Instantiate(ball, pos, Quaternion.identity);
        }
    }
    public int GetScore(){
        return m_score;
    }
    public void SetScore(int value){
        m_score = value;
    }
    public void IncrementScore(){
        m_score += 1;
        m_ui.SetScoreText("SCORE: "+ m_score);
    }
    public bool GetGameOver(){
        return m_gameOver;
    }
    public void SetGameOver(bool state){
        m_gameOver = state;
    }
}
