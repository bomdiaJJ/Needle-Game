using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;

public class Target : SerializedMonoBehaviour {
	[SerializeField] private Dictionary<string, UnityEvent> OnHitByTag = new Dictionary<string, UnityEvent>();

	private void OnTriggerEnter2D(Collider2D other) {
		if (OnHitByTag.ContainsKey(other.tag)) {
			OnHitByTag[other.tag]?.Invoke();
		}
	}

}