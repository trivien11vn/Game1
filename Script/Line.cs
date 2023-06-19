using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        /* getaxisraw de get cac truc di chuyen cua dau vao */
        // o 2D dung getaxisraw, o 3D dung getaxis
        // gia tri getaxisraw tra ve khi bam sang trai : -1; khi sang phai: 1
        // time.delteTime : thoi gian ton tai cua 1 frame
        xDirection = Input.GetAxisRaw("Horizontal");
        
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if ((transform.position.x <= -11.44 && xDirection == -1) || (transform.position.x >= 11.44 && xDirection == 1)) return;
        transform.position = transform.position + new Vector3(moveStep,0,0);

    }
}
