using UnityEngine;
using TMPro;

public class IntVariableToTextMeshPro : MonoBehaviour {
	[SerializeField] private IntVariable _intVariable;
	
	private TextMeshProUGUI _textMeshPro;

	private void Awake() {
		_textMeshPro = GetComponent<TextMeshProUGUI>();
		_textMeshPro.text = _intVariable.Value.ToString();
		_intVariable.OnValueChanged += UpdateText;
	}

	private void UpdateText(int value) {
		_textMeshPro.text = value.ToString();
	}

}