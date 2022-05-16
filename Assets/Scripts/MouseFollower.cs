using UnityEngine;

public class MouseFollower : MonoBehaviour {
    [SerializeField] float _zPosition = 0f;

	private Camera _mainCam;

	private void Awake() {
		_mainCam = Camera.main;
	}

	void Update() {
		Vector3 worldPoint = _mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
		transform.position = new Vector3(worldPoint.x, worldPoint.y, _zPosition);
    }
}
