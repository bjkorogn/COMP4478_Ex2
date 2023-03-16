using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    private TMP_Text scoreText;
    public int score = 0;
    [SerializeField]
    private GameObject GameOverPanel;
    [SerializeField]
    private AudioSource getFishSound;
    [SerializeField]
    private AudioSource bombExplodeSound;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        scoreText.text = "Fishes Caught: " + score;
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Fish")
        {
            score += 1;
            scoreText.text = "Fishes Caught: " + score;
            getFishSound.Play();
        }
        if (col.gameObject.tag == "Bomb")
        {
            bombExplodeSound.Play();
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver() {
        yield return new WaitForSecondsRealtime(0f);
        GameOverPanel.SetActive(true);
        
    }
}
