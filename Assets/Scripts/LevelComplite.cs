﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplite : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}