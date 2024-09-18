using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publisher : MonoBehaviour//, IPublisher
{
   private readonly List<ISubcriber> _suscribers = new List<ISubcriber>();

    public void Subscribe(ISubcriber suscriber)
    {
        _suscribers.Add(suscriber);
    }

    public void NotifySubscribers()
    {
        foreach(ISubcriber subscriberInList in _suscribers)
        {
            //subscriberInList.UpdateSuscriber(this);
        }
    }

    public void Unsubscribe (ISubcriber suscriber)
    {
        _suscribers.Remove(suscriber);
    }

    public void MainBusinessLogic(string message)
    {
        _message = message;
        NotifySubscribers();
    }

    private string _message;
    public string KeyPressed => _message;

    void Update()
    {
        if (Input.anyKeyDown && Input.inputString.Length > 0)
        {
            MainBusinessLogic(Input.inputString[0].ToString());
        }
    }
}
