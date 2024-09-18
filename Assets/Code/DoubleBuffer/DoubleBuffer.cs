using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBuffer 
{
    private Texture2D _frontBuffer;
    private Texture2D _backBuffer;
    private Color[] _pixels;

    public DoubleBuffer(int width, int height)
    {
        _frontBuffer = new Texture2D(width, height);
        _backBuffer = new Texture2D(width, height);
        _pixels = new Color[width * height];
    }

    public void DrawInBackBuffer(System.Action drawAction)
    {
        drawAction.Invoke();
        _backBuffer.SetPixels(_pixels);
        _backBuffer.Apply();
    }

    public void SwapBuffers()
    {
        var temp = _frontBuffer;
        _frontBuffer = _backBuffer;
        _backBuffer = temp;
    }

    public Texture2D GetFrontBuffer()
    {
        return _frontBuffer;
    }
}
