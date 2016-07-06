using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public GameObject token;
	public GameObject tree;
	private float tokenTimer = 2.0f;
	private float treeTimer = 2.0f;

	void Update () {
		tokenTimer -= Time.deltaTime;
		treeTimer -= Time.deltaTime;

		if (tokenTimer < 0) {
			SpawnToken ();
		}
		if (treeTimer < 0) {
			SpawnTree ();
		}
	}

	void SpawnToken() {
		var position = new Vector2 (Random.Range (-6, 6), 6);
		Instantiate (token, position, Quaternion.identity);
		tokenTimer = Random.Range (0.5f, 2.5f);
	}

	void SpawnTree() {
		var position = new Vector2 (Random.Range (-6, 7), 6);
		var tr = Instantiate (tree, position, Quaternion.identity) as GameObject;
		treeTimer = Random.Range (0.5f, 2.5f);
		tr.GetComponent<Rigidbody2D> ().gravityScale = Random.Range (1, 3);
	}
}
