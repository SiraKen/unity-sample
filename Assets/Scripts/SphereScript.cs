using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

        // 乱数でスタート位置を決める
        int value = Random.Range(0, 10 + 1);
        Debug.Log(value);
        if (value % 2 == 0)
        {
            // Right
            this.transform.Translate(new Vector3(6f, 0, 0));
        }
        else
        {
            // Left
            this.transform.Translate(new Vector3(-6f, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!isGameOver)
        {
            Debug.Log(collision.gameObject.name);
            if (collision.gameObject.name == "Floor")
            {
                Debug.Log("Game Over");
                isGameOver = true;
            }
        }

    }
}
