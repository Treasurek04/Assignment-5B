using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public static int score;  
    public GameObject pauseMenu;

    private string CurrentLevelName = string.Empty;


    //#region This code makes this class a singleton

    //public static GameManager instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);

    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //        Debug.LogError("Trying to instantiate a second instance of singleton Game Manager");
    //    }
    //}

    //#endregion


    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to load level " + levelName);
            return;
        }

        this.CurrentLevelName = levelName;

    }

    public void UnLoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to unload level " + levelName);
            return;
        }

    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to unload level " + CurrentLevelName);
            return;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
}
