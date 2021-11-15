using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCubeBehaviourScript : MonoBehaviour
{
    public float maxPosY = 1.5f;
    public float minPosY = -1.5f;
    public float moveSpeed = 1.0f;
    public bool isDropping = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Visual Studio.");
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
