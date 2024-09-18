using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour,ISubcriber 
{
    [SerializeField] public bool okSubscribme = false;
    [HideInInspector] public bool isSubscripted = false;

    public void UpdateSuscriber(IPublisher publisher)
    {
        if ( publisher is Publisher client )
        {
            Debug.Log($"Soy {transform.name}, presionaron la teecla {client.KeyPressed}");
        }
    }
}
