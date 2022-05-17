using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;

public class Target : SerializedMonoBehaviour {
	[SerializeField] private Dictionary<string, UnityEvent> OnHitByTag = new Dictionary<string, UnityEvent>();

#if UNITY_EDITOR
	[SerializeField] private bool _LogHitsWithTagsNotInDictionary = false;
#endif

	private void OnTriggerEnter2D(Collider2D other) {
		if (OnHitByTag.ContainsKey(other.tag)) {
			OnHitByTag[other.tag]?.Invoke();
		}
#if UNITY_EDITOR
		else if (_LogHitsWithTagsNotInDictionary) {
			Debug.LogWarning($"{other.tag} was hit by {name} but no UnityEvent is registered for it.");
		}
#endif
	}

}