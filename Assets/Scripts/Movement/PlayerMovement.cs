using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Movement m_Movement;

    // Start is called before the first frame update
    void Start()
    {
        m_Movement = GetComponent<Movement> ();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove ();
    }

    void PlayerMove()
    {
        if (Input.GetButton (gameObject.name + "UP"))
        {
            Debug.Log (gameObject + " is pressing UP");
            m_Movement.Move (true);
        }
        if (Input.GetButton (gameObject.name + "DOWN"))
        {
            m_Movement.Move (false);
        }
    }
}
