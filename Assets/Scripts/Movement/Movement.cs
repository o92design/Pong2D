using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementData m_MovementData;
    public Transform m_Transform;

    void Start ()
    {
        // Initialize movement components
        m_MovementData = GetComponent<MovementData> ();
        m_Transform = GetComponent<Transform> ();
    }

    public void Move (bool p_moveUp)
    {
        if (p_moveUp)
        {
            m_Transform.Translate (Vector3.up * m_MovementData.m_speed * Time.deltaTime);
        }
        else
        {
            m_Transform.Translate (Vector3.down * m_MovementData.m_speed * Time.deltaTime);
        }
    }

    public void MoveLeft(bool p_left)
    {
        if (p_left)
        {
            m_Transform.Translate (Vector3.left * m_MovementData.m_speed * Time.deltaTime);
        }
        else
        {
            m_Transform.Translate (Vector3.right * m_MovementData.m_speed * Time.deltaTime);
        }
    }
}
