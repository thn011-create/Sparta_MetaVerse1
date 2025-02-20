using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlayer : MonoBehaviour
{
    public string playerTag = "Player";

    public string targetSceneName = "GameScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
