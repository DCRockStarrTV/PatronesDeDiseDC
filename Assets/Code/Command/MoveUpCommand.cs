using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpCommand : ICommand
{
    private Transform _transform;
    private float _distance;

    public MoveUpCommand(Transform transform, float distance)
    {
        _transform = transform;
        _distance = distance;
    }

    public void Execute()
    {
        _transform.position += Vector3.up * _distance;
    }

    public void Undo()
    {
        _transform.position -= Vector3.up * _distance;
    }
}

public class MoveDownCommand : ICommand
{
    private Transform _transform;
    private float _distance;

    public MoveDownCommand(Transform transform, float distance)
    {
        _transform = transform;
        _distance = distance;
    }

    public void Execute()
    {
        _transform.position += Vector3.down * _distance;
    }

    public void Undo()
    {
        _transform.position -= Vector3.down * _distance;
    }
}

