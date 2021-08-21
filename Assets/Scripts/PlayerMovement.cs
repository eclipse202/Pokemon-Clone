using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        PlayerMovementCommand();
    }
    public void PlayerMovementCommand()
    {
        Vector2 pos = gameObject.transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector2(pos.x, pos.y + (Time.deltaTime * playerSpeed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector2(pos.x - (Time.deltaTime * playerSpeed), pos.y);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector2(pos.x, pos.y - (Time.deltaTime * playerSpeed));
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector2(pos.x + (Time.deltaTime * playerSpeed), pos.y);
        }
    }
}
