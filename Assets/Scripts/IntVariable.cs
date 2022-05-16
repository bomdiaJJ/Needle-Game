using System;
using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Modular Data/Int Variable")]
public class IntVariable : ScriptableObject {
	[SerializeField] private int _value;

	public event Action<int> OnValueChanged;

	public int Value {
		get {
			return _value;
		}
		set {
			_value = value;
			OnValueChanged?.Invoke(_value);
		}
	}

	public void AddValue(int value) {
		Value += value;
	}
	
}