using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    GameObject gameOverPanel;
    [SerializeField]
    TMP_Text gameOverText;
    [SerializeField]
    private GameObject spawner;
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverPanel.activeSelf)
        {
            gameOverText.gameObject.SetActive(true);
            spawner.SetActive(false);
            player.SetActive(false);

            // R to restart
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                gameOverPanel.SetActive(false);
                spawner.SetActive(true);
                player.SetActive(true);
            }
        }
    }
}
