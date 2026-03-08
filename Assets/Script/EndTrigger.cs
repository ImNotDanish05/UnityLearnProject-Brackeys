using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.CompleteLevel();
        }
    }
}