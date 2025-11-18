using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Transform respawnPoint;

    // Court boundaries
    public float xMin = -10f;
    public float xMax = 10f;
    public float yMin = -5f;
    public float yMax = 10f;  // optional if ball goes too high
    public float zMin = -15f;
    public float zMax = 15f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 pos = transform.position;

        // Check if ball is out of bounds on any axis
        if (pos.x < xMin || pos.x > xMax ||
            pos.y < yMin || pos.y > yMax ||
            pos.z < zMin || pos.z > zMax)
        {
            RespawnBall();
        }
    }

    void RespawnBall()
    {
        // Stop all movement
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Reset position and rotation
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
