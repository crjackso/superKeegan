using UnityEngine;
using System.Collections;

public class PlayerCollide : MonoBehaviour {

	public static int health = 3;
	public AudioClip tokenPickupClip;
	public AudioClip playerHurtClip;
	public int tokenCount;

	void OnTriggerEnter2D(Collider2D other) {		
		if (other.tag == "Tree") {
			health--;
			GetComponent<AudioSource> ().PlayOneShot(playerHurtClip, 0.5f);

			if (health <= 0) {
				Destroy (gameObject);
			}
		} else if (other.tag == "Token") {
			// get a token
			Debug.Log("yep");
			GetComponent<AudioSource> ().PlayOneShot (tokenPickupClip, 0.5f);
			tokenCount++;
			Destroy (other.gameObject);
		}
	}
}
