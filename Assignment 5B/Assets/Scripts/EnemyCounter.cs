using System.Collections;
using System.Collections.Generic;
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
        enemiesLeft--;
        if (enemiesLeft < 0) enemiesLeft = 0;
        UpdateEnemyUI();
    }

    private void UpdateEnemyUI()
    {
        enemiesLeftText.text = "Enemies Left: " + enemiesLeft;
    }
}
