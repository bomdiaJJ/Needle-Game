using UnityEngine;

[CreateAssetMenu(fileName = "GameOverManager", menuName = "Managers/Game Over Manager")]
public class GameOverManager : ScriptableObject {
	
	public void GameOver() {
		Time.timeScale = 0f;
		Debug.Log("Game Over");
	}
}