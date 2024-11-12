using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public EnemyCounter enemyCounter;
    public Text gameOverText;
    private bool gameOver = false;

    void Start()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            RetryGame();
        }
    }

    private void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOver = true;
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
                gameOverText.text = "You Win! Press R to Retry";
            }
            Time.timeScale = 0f; 
        }
    }
}
