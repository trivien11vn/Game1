using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    private void Start(){
        m_gc = FindObjectOfType<GameController>();

    }
    // o day khong can phuong thuc start, update
    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Player")){
            m_gc.IncrementScore();
            Destroy(gameObject);
            Debug.Log("Đã va chạm với giá đỡ");
        }
    }
    private void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("DeadthZone")){
            m_gc.SetGameOver(true);
            Destroy(gameObject);
            Debug.Log("Đã va chạm với deadth_zone");
        }
    }
}
