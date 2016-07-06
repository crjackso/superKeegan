using UnityEngine;
using System.Collections;

public class Boulder : MonoBehaviour {

	void FixedUpdate() {
		var position = gameObject.transform.position;
		float angle = Mathf.Atan2(position.y, position.x) * Mathf.Rad2Deg;
		var rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		gameObject.transform.rotation = rotation;
	}
}
