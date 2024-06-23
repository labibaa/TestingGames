using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if (!GameManager.gameStarted)
        {
            return; // Exit the Update method if the game has not started
        }

        // Camera movement logic
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(horizontal, vertical, 0);
    }
}

