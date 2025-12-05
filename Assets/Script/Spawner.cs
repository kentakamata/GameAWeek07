using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects; // 0=triangle,1=square,2=circle
    public float interval = 1.5f;

    private float timer;

    void Update()
    {
        if (!GameManager.Instance.isPlaying) return;

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            int r = Random.Range(0, objects.Length);
            Instantiate(objects[r], transform.position, Quaternion.identity);
        }
    }
}
