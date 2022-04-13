using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public bool isGameOver;
    public GameObject canvas;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Canvas>().enabled = false;

        rigidbody = GetComponent<Rigidbody>();

        SetStartPosition();
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

                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;

                canvas.GetComponent<Canvas>().enabled = true;
                isGameOver = true;
            }
        }

    }

    public void SetStartPosition()
    {
        Debug.Log("SetStartPosition");
        
        // 乱数でスタート位置を決める
        int value = Random.Range(0, 10 + 1);

        if (value % 2 == 0)
        {
            // Right
            // this.transform.Translate(new Vector3(6f, 0, 0));
            this.transform.position = new Vector3(6f, 10f, 0);
        }
        else
        {
            // Left
            // this.transform.Translate(new Vector3(-6f, 0, 0));
            this.transform.position = new Vector3(-6f, 10f, 0);
        }

        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Canvas>().enabled = false;
        isGameOver = false;
    }
}
