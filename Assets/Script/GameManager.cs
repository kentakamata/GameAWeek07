using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isPlaying = true;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartText;

    private float time = 0f;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        gameOverText.text = "";
        restartText.text = "";
    }

    void Update()
    {
        if (isPlaying)
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + time.ToString("F1");
        }
    }

    public void GameOver()
    {
        if (!isPlaying) return;

        isPlaying = false;

        gameOverText.text = "Game Over";
        restartText.text = "Restart in 3...";

        StartCoroutine(Restart());
    }

    System.Collections.IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        restartText.text = "Restart in 2...";
        yield return new WaitForSeconds(1);
        restartText.text = "Restart in 1...";
        yield return new WaitForSeconds(1);

        // シーンをリロード
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
