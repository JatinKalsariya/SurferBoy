using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform Player;
    float offSet;
    void Start()
    {
        offSet = transform.position.z - Player.position.z;

    }
    void Update()
    {
        var movement = transform.position;
        movement.z = Player.position.z + offSet;
        transform.position = movement;
    }
}
