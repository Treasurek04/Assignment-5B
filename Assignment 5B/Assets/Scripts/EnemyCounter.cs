using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public int totalEnemies = 18;
    private int enemiesLeft;
    public Text enemiesLeftText;

    void Start()
    {
        
        enemiesLeft = totalEnemies;
        UpdateEnemyUI();
    }

    public void EnemyDestroyed()
    {
        if (enemiesLeft > 0)
        {
            enemiesLeft -= 1;
            UpdateEnemyUI();
        }
    }

    public int TotalEnemiesLeft()
    {
        return enemiesLeft;
    }

    private void UpdateEnemyUI()
    {
        if (enemiesLeftText != null)
        {
            enemiesLeftText.text = "Enemies Left: " + enemiesLeft;
        }
    }
}
