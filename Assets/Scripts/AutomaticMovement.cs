using UnityEngine;

public class AutomaticMovement : MonoBehaviour {
	[SerializeField] private float _speed = 3f;
	
	private void Update() {
		transform.position += Vector3.left * _speed * Time.deltaTime;
	}
}