using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRender : MonoBehaviour
{
    [Header("Press Space")]
    [SerializeField] private GameObject m_prefab;

    private Scene m_scene;
	
	void Start ()
    {
        m_scene = new Scene();
	}

    void Render( )
    {
        List<GameObject> transformToRemove = new List<GameObject>();
        foreach( Transform child in this.transform )
        {
            transformToRemove.Add(child.gameObject);
        }

        for (int i = 0; i < transformToRemove.Count; i++)
        {
            Destroy(transformToRemove[i]);
        }

        transformToRemove.Clear();

        m_scene.Draw();

        Framebuffer fb = m_scene.GetBuffer();
        int[] pixels = fb.GetPixels();
        for (int x = 0; x < Framebuffer.kWIDTH; x++)
        {
            for (int y = 0; y < Framebuffer.kHEIGHT; y++)
            {
                int posIndex = (Framebuffer.kWIDTH * y) + x;

                Vector3 pos = new Vector3(x * 0.5f, 0f, y * 0.5f);
                GameObject instantiate = GameObject.Instantiate(m_prefab, pos, new Quaternion(0f, 0f, 0f, 1f), this.transform);
                instantiate.name = "Cubxel: " + posIndex;

                MeshRenderer mr = instantiate.GetComponent<MeshRenderer>();
                
                mr.material.color = (pixels[posIndex] > 0) ? Color.blue : Color.white;
            }
        }
    }

    void Update( )
    {
        if( Input.GetKey(KeyCode.Space))
        {
            Render();
        }
    }
	
}
