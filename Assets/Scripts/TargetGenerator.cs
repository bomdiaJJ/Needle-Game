using System.Collections;
using UnityEngine;

public class TargetGenerator : MonoBehaviour {
    
	[SerializeField] private GameObject _targetPrefab;
	[SerializeField] private float _minY = -1f;
	[SerializeField] private float _maxY = 1f;

	[SerializeField] private float _timeBetweenTargets = 1f;

	private Camera _mainCam;

	private void Awake() {
		_mainCam = Camera.main;
	}

	public void SpawnTarget() {
		GameObject target = Instantiate(_targetPrefab);
		target.transform.position = new Vector3(_mainCam.aspect * _mainCam.orthographicSize + .5f, Random.Range(_minY, _maxY), 0f);
	}

	private IEnumerator Start() {
		while (true) {
			yield return new WaitForSeconds(_timeBetweenTargets);
			SpawnTarget();
		}
	}

}