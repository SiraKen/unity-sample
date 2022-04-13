using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{

    float mouse_sensitivity = 0.5f;
    float touch_sensitivity = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
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
    }
}
