using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublisherController : MonoBehaviour
{
    [SerializeField] Publisher publisher;
    [SerializeField] public List<Consumer> listPosibleConsumers;

    private void Update()
    {
        foreach(Consumer consumer in listPosibleConsumers)
        {
            if (consumer)
            {
                if (!consumer.isSubscripted && consumer.okSubscribme)
                {
                    consumer.isSubscripted = true;
                    publisher.Subscribe(consumer);
                }

                if (!consumer.isSubscripted && !consumer.okSubscribme)
                {
                    consumer.isSubscripted = false;
                    publisher.Unsubscribe(consumer);
                }
            }
        }
    }
}
