using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -6f)
        {
            GameManager.Instance.GameOver();
            Destroy(gameObject);
        }
    }
}
