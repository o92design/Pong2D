using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public bool m_BallUp;
    public bool m_BallLeft;

    // These are for testing
    public float m_maxYPosition;
    public float m_minYPosition;

    public float m_maxXPosition;
    public float m_minXPosition;

    public Movement m_Movement;
    // Start is called before the first frame update
    void Start()
    {
        m_Movement = GetComponent<Movement> ();
    }

    // Update is called once per frame
    void Update()
    {
        DetermineDirection ();

        if(m_BallUp)
        {
            m_Movement.Move (true);
        }
        else
        {
            m_Movement.Move (false);
        }
    }

    public void DetermineDirection()
    {
        if (m_Movement.m_Transform.position.y < m_minYPosition)
        {
            m_BallUp = true;
        }
        else if (m_Movement.m_Transform.position.y > m_maxYPosition)
        {
            m_BallUp = false;
        }

        if (m_Movement.m_Transform.position.x < m_minXPosition)
        {
            m_BallLeft = true;
        }
        else if (m_Movement.m_Transform.position.x > m_maxXPosition)
        {
            m_BallLeft = false;
        }
    }
}
