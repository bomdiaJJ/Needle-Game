using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Modular Data/Float Variable")]
public class FloatVariable : ScriptableObject {
	[SerializeField] private float _value;

	public event Action<float> OnValueChanged;

	public float Value {
		get {
			return _value;
		}
		set {
			_value = value;
			OnValueChanged?.Invoke(_value);
		}
	}
	
}