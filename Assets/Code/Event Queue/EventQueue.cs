using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueue : MonoBehaviour
{
    private Queue<GameEvent> _eventQueue = new Queue<GameEvent>();

    public void EnqueueEvent(GameEvent gameEvent)
    {
        _eventQueue.Enqueue(gameEvent);
    }

    public void ProcessEvents()
    {
        while (_eventQueue.Count > 0)
        {
            GameEvent gameEvent = _eventQueue.Dequeue();
            HandleEvent(gameEvent);
        }
    }

    private void HandleEvent(GameEvent gameEvent)
    {
        switch (gameEvent.EventType)
        {
            case "PlayerScored":
                Debug.Log("Player scored: " + gameEvent.EventData);
                break;
            case "GameOver":
                Debug.Log("Game Over! Final Score: " + gameEvent.EventData);
                break;
                // Agrega más tipos de eventos según sea necesario
        }
    }
}
