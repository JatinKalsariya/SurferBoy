using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool isGameStarted = false;
    bool isLeftDown = false;

    void Update()
    {
        var pos = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow) || isLeftDown)
        {
            isGameStarted = true;
            pos.x -= .1f;
        }
        else
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isGameStarted = true;
        }

        if (isGameStarted)
        {
            pos.z += .1f;
        }
        transform.position = pos;
    }

    public void touchLeftDown(bool isDown)
    {
        print("Touch left Button Down");
        isLeftDown = isDown;
    }

}
