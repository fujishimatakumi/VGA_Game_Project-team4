using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chengCamera : MonoBehaviour
{
    [SerializeField] Camera mc;
    [SerializeField] Camera sc;
    [SerializeField] float m_sabiStart = 1;
    [SerializeField] float m_sabiEnd = 1;
    // Start is called before the first frame update
    void Start()
    {
        mc.enabled = true;
        sc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_sabiStart > 0)
        {
            m_sabiStart -= Time.deltaTime;
        }
        if (m_sabiStart < 0)
        {
            mc.enabled = false;
            sc.enabled = true;
            m_sabiEnd -= Time.deltaTime;
        }
        if (m_sabiEnd < 0)
        {
            mc.enabled = true;
            sc.enabled = false;
            m_sabiStart = 0;
        }
        
    }
}
