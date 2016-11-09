using UnityEngine;
using System.Collections;

public class MovedByPlayerInput : MonoBehaviour
{
    [SerializeField]
    private string horizontalAxisName = "Vertical";

    [SerializeField]
    private float speed = 10f;

    private void Update()
    {
        Vector3 pos = transform.position;

        // Add Input
        pos.y += Input.GetAxis(horizontalAxisName) * speed * Time.deltaTime;
                                                             // |            |
                                                             // Time.deltaTime => Time since last Frame was rendered. Basically 1 / FramesPerSecond.
                                                             //                   (with about 60fps this is approximately 0.02 each frame)
                                                             //                   This way the object always moves the same distance over time, regardless of FrameRates.
                                                             //                   [imagine the difference between someone running your game with 50 and someone having 100 fps]
                                                             //                   [-> Extreme difficulty increase since everything is now twice as fast!]

        // Apply new position
        transform.position = pos;
    }
}
