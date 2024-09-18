using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private EventQueue _eventQueue;

    private void Start()
    {
        _eventQueue = GetComponent<EventQueue>();
    }

    public void Score(int points)
    {
        GameEvent scoreEvent = new GameEvent("PlayerScored", points);
        _eventQueue.EnqueueEvent(scoreEvent);
    }

    public void GameOver(int finalScore)
    {
        GameEvent gameOverEvent = new GameEvent("GameOver", finalScore);
        _eventQueue.EnqueueEvent(gameOverEvent);
    }
}
