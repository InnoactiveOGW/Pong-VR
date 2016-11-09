using UnityEngine;
using System.Collections;

public class ConstrainPosition : MonoBehaviour
{
    [SerializeField]
    private float constrainY = 3.3f;

    // LateUpdate is called after all Updates are Finished.
    // For More information: https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void LateUpdate()
    {
        Vector3 pos = transform.position;

        // Clamp Y, so it is never smaller or bigger than constrainY
        pos.y = Mathf.Clamp(pos.y, -constrainY, constrainY);

        // Update Position
        transform.position = pos;
    }
}
