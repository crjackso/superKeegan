using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreText;

	private int score;

	void Start () {
		UpdateScore ();
	}

	public void AddScore(int newScore) {
		score += newScore;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreText.text = score.ToString();
	}
}
