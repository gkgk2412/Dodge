using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//사용자의 키보드 입력을 감지하여 플레이어 이동

public class PlayerController : MonoBehaviour
{    
    public Rigidbody rb;        //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8.0f;  //속도

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //up
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            rb.AddForce(0f, 0f, speed);
        }

        //down
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            rb.AddForce(0f, 0f, speed);
        }

        //left
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rb.AddForce(0f, 0f, speed);
        }

        //right
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rb.AddForce(0f, 0f, speed);
        }
    }

    public void Die()
    {
        this.gameObject.SetActive(false);
    }

}
