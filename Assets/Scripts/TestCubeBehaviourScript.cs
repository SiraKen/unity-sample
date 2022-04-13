using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCubeBehaviourScript : MonoBehaviour
{
    public float maxPosY = 1.5f;
    public float minPosY = -1.5f;
    public float moveSpeed = 1.0f;
    public bool isDropping = false;
    public bool canMove = false;
    float mouse_sensitivity = 0.5f;
    float touch_sensitivity = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        /* 上下に動くだけ */
        /*
        float objPosY = this.transform.position.y;
        if (!isDropping)
        {
            if (objPosY < maxPosY)
            {
                this.transform.Translate(new Vector3(0, 0.01f, 0));
            } else
            {
                isDropping = true;
            }
            
        } else
        {
            if (minPosY < objPosY)
            {
                this.transform.Translate(new Vector3(0, -0.01f, 0));
            }
            else
            {
                isDropping = false;
            }
        }
        */
        //this.transform.Translate(new Vector3(0.01f, 0, 0));

        Move();
        
    }

    void Move()
    {
        // Speed Changer
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 2.0f;
        }
        else
        {
            moveSpeed = 1.0f;
        }

        // Move
        if (canMove)
        {
            if (Input.GetMouseButton(0))
            {
                float dx, dy;

                // ドラッグ
                dx = Input.GetAxis("Mouse X") * mouse_sensitivity;
                dy = Input.GetAxis("Mouse Y") * mouse_sensitivity;

                // スワイプ
                if (Input.touchCount > 0)
                {
                    dx = Input.touches[0].deltaPosition.x * touch_sensitivity;
                    dy = Input.touches[0].deltaPosition.y * touch_sensitivity;
                }

                this.transform.Translate(dx, 0.0f, 0.0f);
            }
            
            // キー操作
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(moveSpeed * -0.05f, 0, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(new Vector3(moveSpeed * 0.05f, 0, 0));
            }
        }
    }

    public void Initialize()
    {
        this.transform.position = new Vector3(0, 0, 0);
        canMove = true;
    }
}
