
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SineWaveMovement : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;
    public float zSpeed = 1f;
    public float zLimit = 4f;

    private Vector3 startPosition;
    private Rigidbody rb;
    private bool movingForward = true;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Sine wave movement along X-axis
        float x = startPosition.x +
                  Mathf.Sin(Time.fixedTime * frequency) * amplitude;

        // Forward and backward movement along Z-axis
        float z = rb.position.z +
                  zSpeed * Time.fixedDeltaTime *
                  (movingForward ? 1f : -1f);

        // Check Z-axis boundaries
        if (movingForward && z >= startPosition.z + zLimit)
        {
            z = startPosition.z + zLimit;
            movingForward = false;
        }
        else if (!movingForward && z <= startPosition.z)
        {
            z = startPosition.z;
            movingForward = true;
        }

        // Create new position
        Vector3 newPosition = new Vector3(
            x,
            startPosition.y,
            z
        );

        // Move Rigidbody
        rb.MovePosition(newPosition);
    }
}
    