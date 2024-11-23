using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform playerTransform;
    private float _score = 0.0f;    

    public void AddScore(float score)
    {
        this._score += score;
        scoreText.text = this._score.ToString("0");
    }

    private void Update()
    {
        if (playerTransform is not null)
        {
            this._score += playerTransform.position.x*Time.deltaTime;
            scoreText.text = this._score.ToString("0");
        }
    }
}
