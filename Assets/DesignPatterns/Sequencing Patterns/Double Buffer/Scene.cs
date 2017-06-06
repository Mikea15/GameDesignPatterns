using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene
{
    private const int kBUFFER_SIZE = 2;
    private Framebuffer[] m_buffers;
    private Framebuffer m_current;
    private Framebuffer m_next;

    public Scene()
    {
        m_buffers = new Framebuffer[kBUFFER_SIZE];
        for (int i = 0; i < m_buffers.Length; i++)
        {
            m_buffers[i] = new Framebuffer();
        }
        m_current = m_buffers[0];
        m_next = m_buffers[1];
    }

    public Framebuffer GetBuffer( )
    {
        return m_current;
    }

    public void Draw()
    {
        m_next.Clear();

        //
        // Randomly draws pixels.. 
        // Test purposes only.
        // 
        for (int i = 0; i < Framebuffer.kWIDTH; i++)
        {
            int rX = Random.Range(0, Framebuffer.kWIDTH);
            int rY = Random.Range(0, Framebuffer.kHEIGHT);

            m_next.Draw(rX, rY);
        }

        Swap();
    }


    private void Swap( )
    {
        Framebuffer temp = m_current;
        m_current = m_next;
        m_next = temp;
    }


}
