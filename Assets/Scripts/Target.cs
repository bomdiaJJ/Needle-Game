using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour {
	[SerializeField] UnityEvent OnHitByPlayer;
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			OnHitByPlayer?.Invoke();
		}
	}
}