using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private List<GameEvent> onAwakeGameEvent = new();
	[SerializeField] private List<GameEvent> onStartGameEvent = new();
	[SerializeField] private BoolVariable isPaused;

	private void Awake()
	{
		RaiseGameEvents(onAwakeGameEvent);
	}

	private void Start()
	{
		RaiseGameEvents(onStartGameEvent);
		isPaused.Value = false;
	}

	private void RaiseGameEvents(List<GameEvent> gameEvents)
	{
		foreach (GameEvent gameEvent in gameEvents)
			gameEvent.Raise();
	}

	public void PauseGame() => isPaused.Value = true;

	public void ResumeGame() => isPaused.Value = false;
}