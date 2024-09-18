using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent 
{
    public string EventType { get; private set; }
    public object EventData { get; private set; }

    public GameEvent(string eventType, object eventData)
    {
        EventType = eventType;
        EventData = eventData;
    }
}
