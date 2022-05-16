using UnityEngine;
using Shapes;

public class LinePositioner : MonoBehaviour {
    private Line _line;
	private Camera _mainCam;

	private void Awake() {
		_line = GetComponent<Line>();
		_mainCam = Camera.main;
	}

	private void Start() {
		transform.position = Vector3.zero;

		float halfHorizontalCameraWidthInWorldUnits = _mainCam.aspect * _mainCam.orthographicSize;
		_line.Start = new Vector3(-halfHorizontalCameraWidthInWorldUnits, 0f);
	}

	void Update() {
		Vector3 worldPoint = _mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
		_line.End = new Vector3(worldPoint.x, worldPoint.y, 0);
    }

	private void OnGUI() {
		GUI.Label(new Rect(10, 10, 250, 20), "Mouse Position: " + Input.mousePosition.ToString());
	}
}
