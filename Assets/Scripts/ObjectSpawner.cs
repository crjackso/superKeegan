using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public GameObject token;
	public GameObject boulder;
	private float tokenTimer = 2.0f;
	private float boulderTimer = 2.0f;

	void Update () {
		tokenTimer -= Time.deltaTime;
		boulderTimer -= Time.deltaTime;

		if (tokenTimer < 0) {
			SpawnToken ();
		}
		if (boulderTimer < 0) {
			SpawnBoulder ();
		}
	}

	void SpawnToken() {
		var position = new Vector2 (Random.Range (-6, 6), 6);
		Instantiate (token, position, Quaternion.identity);
		tokenTimer = Random.Range (0.5f, 2.5f);
	}

	void SpawnBoulder() {
		var position = new Vector2 (Random.Range (-6, 7), 6);

		var bould = Instantiate (boulder, position, Quaternion.identity) as GameObject;
		boulderTimer = Random.Range (0.5f, 2.5f);
		bould.GetComponent<Rigidbody2D> ().gravityScale = Random.Range (1, 3);
	}
}
