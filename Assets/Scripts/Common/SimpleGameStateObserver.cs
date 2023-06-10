﻿using UnityEngine;
using SDD.Events;

public abstract class SimpleGameStateObserver : MonoBehaviour,IEventHandler {

	public virtual void SubscribeEvents()
	{
		EventManager.Instance.AddListener<GameMainMenuEvent>(GameMainMenu);
		EventManager.Instance.AddListener<GameCreditsEvent>(GameCredits);
		EventManager.Instance.AddListener<GameCreateSessionEvent>(GameCreateSession);
		EventManager.Instance.AddListener<GameJoinSessionEvent>(GameJoinSession);
		EventManager.Instance.AddListener<GameResumeEvent>(GameResume);
		EventManager.Instance.AddListener<GamePausedEvent>(GamePaused);
		EventManager.Instance.AddListener<GameOverEvent>(GameOver);
		EventManager.Instance.AddListener<GameStatisticsChangedEvent>(GameStatisticsChanged);
	}

	public virtual void UnsubscribeEvents()
	{
		EventManager.Instance.RemoveListener<GameMainMenuEvent>(GameMainMenu);
		EventManager.Instance.RemoveListener<GameCreditsEvent>(GameCredits);
		EventManager.Instance.RemoveListener<GameCreateSessionEvent>(GameCreateSession);
		EventManager.Instance.RemoveListener<GameJoinSessionEvent>(GameJoinSession);
		EventManager.Instance.RemoveListener<GameResumeEvent>(GameResume);
		EventManager.Instance.RemoveListener<GamePausedEvent>(GamePaused);
		EventManager.Instance.RemoveListener<GameOverEvent>(GameOver);
		EventManager.Instance.RemoveListener<GameStatisticsChangedEvent>(GameStatisticsChanged);
	}

	protected virtual void Awake()
	{
		SubscribeEvents();
	}

	public void OnDestroy()
	{
		UnsubscribeEvents();
	}

	protected virtual void GameMainMenu(GameMainMenuEvent e)
	{

	}
	
	protected virtual void GameCredits(GameCreditsEvent e)
	{

	}

	protected virtual void GameCreateSession(GameCreateSessionEvent e)
	{

	}

	protected virtual void GameJoinSession(GameJoinSessionEvent e)
	{

	}

	protected virtual void GameResume(GameResumeEvent e)
	{

	}

	protected virtual void GamePaused(GamePausedEvent e)
	{

	}

	protected virtual void GameOver(GameOverEvent e)
	{

	}
	
	protected virtual void GameStatisticsChanged(GameStatisticsChangedEvent e)
	{
		
	}
}
