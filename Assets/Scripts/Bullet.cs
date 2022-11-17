using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(GlobalTags.ENEMY_TAG))
        {
            Destroy(collision.gameObject);
        }
        
        Destroy(gameObject);
    }
}
