using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField]
    private float startSpeed;

    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        AddInitialForce();
    }

    private void AddInitialForce()
    {
        Vector3 initialVelocity;

        // Set it to either -1 or 1.
        initialVelocity.x = Random.Range(0, 2) == 0 ? -1 : 1;

        initialVelocity.x *= startSpeed;

        // Add a random speed to the y and z axis.
        initialVelocity.y = Random.Range(-startSpeed, startSpeed);
        initialVelocity.z = Random.Range(-startSpeed, startSpeed);

        rigidbody.velocity = initialVelocity;
    }

    public void AddRelativeForce(float value)
    {
        rigidbody.velocity = rigidbody.velocity * value;
        rigidbody.AddForce(Vector3.up * Random.Range(-value, value));
    }

    public void AddForce(Vector3 force)
    {
        rigidbody.AddForce(force, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deathzone")
        {
            Debug.Log("Game Over!"); // Debug.log prints something into the console.
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        AddInitialForce();
    }
}
