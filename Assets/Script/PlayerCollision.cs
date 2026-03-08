using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Transform player;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision" + collision.collider.tag);
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Collision with Obstacle");
            player.GetComponent<PlayerMovement>().enabled = false;
            FindFirstObjectByType<GameManager>().EndGame();

        }


    }
}
