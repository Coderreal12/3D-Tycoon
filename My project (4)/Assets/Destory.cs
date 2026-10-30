using UnityEngine;

public class Destory : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pellet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
