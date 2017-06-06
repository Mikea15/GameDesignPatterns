using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framebuffer
{
    public const int kWIDTH = 32;
    public const int kHEIGHT = 24;

    private int[] m_pixels;

    public Framebuffer()
    {
        m_pixels = new int[kWIDTH * kHEIGHT];

        Clear();
    }

    public void Clear()
    {
        for (int i = 0; i < m_pixels.Length; i++)
        {
            m_pixels[i] = 0;
        }
    }

    public void Draw(int x, int y)
    {
        m_pixels[(kWIDTH * y) + x] = 1;
    }

    public  int[] GetPixels( )
    {
        return m_pixels;
    }
}
