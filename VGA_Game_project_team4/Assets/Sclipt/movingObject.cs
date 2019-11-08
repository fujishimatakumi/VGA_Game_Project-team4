using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class movingObject : MonoBehaviour
{
    [SerializeField] float m_spead = 1f;
    Rigidbody m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_rb.velocity = Vector3.left * m_spead;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
