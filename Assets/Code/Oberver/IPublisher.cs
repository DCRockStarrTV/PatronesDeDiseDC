using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPublisher 
{
    public void Subscribe(ISubcriber subcriber);
    public void Unsubscriber(ISubcriber subcriber);
    public void NotifySubscribers();
    public void MainBusinessLogic(string message);
}
