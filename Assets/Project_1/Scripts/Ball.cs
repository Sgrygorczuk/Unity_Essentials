using UnityEngine;

public class Ball : MonoBehaviour
{
    //==================================================================================================================
    // Trigger 
    //==================================================================================================================
    
    //If the ball falls off the course and it will hit a collider that will destory it 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
