using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = gameObject.transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new Vector2(pos.x, pos.y + 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector2(pos.x - 1, pos.y);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector2(pos.x, pos.y - 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector2(pos.x + 1, pos.y);
        }
    }
}
