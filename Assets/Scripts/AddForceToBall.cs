using UnityEngine;
using System.Collections;

public class AddForceToBall : MonoBehaviour
{
    [SerializeField]
    private float forceMultiplierOnCollision = 1.2f;

    // OnCollisionEnter is called when the Collider of an Object that has a Rigidbody intersects with another Collider.
    // It will be called on all scripts on both objects.
    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.collider.GetComponent<Ball>();

        if (ball != null)
        {
            ball.AddRelativeForce(forceMultiplierOnCollision);
        }
    }
}
