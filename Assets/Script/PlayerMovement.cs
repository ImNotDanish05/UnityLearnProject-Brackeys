using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    void FixedUpdate()
    {
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
