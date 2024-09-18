using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBufferExample : MonoBehaviour
{
    private DoubleBuffer _doubleBuffer;
    public int width = 256;
    public int height = 256;
    private Material _material;

    private void Start()
    {
        _doubleBuffer = new DoubleBuffer(width, height);
        _material = new Material(Shader.Find("Unlit/Texture"));
    }

    private void Update()
    {
        // Dibujar en el back buffer
        _doubleBuffer.DrawInBackBuffer(() =>
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //_doubleBuffer(x, y, new Color(Random.value, Random.value, Random.value));
                }
            }
        });

        // Intercambiar búferes
        _doubleBuffer.SwapBuffers();
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, width, height), _doubleBuffer.GetFrontBuffer());
    }
}
