using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class saaaaaa : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rb;
    [SerializeField] private float m_acceleration = 10;
    [SerializeField] private float m_maxSpeed = 50;
    [SerializeField] private float m_defaultDrag = 8;
    [SerializeField] private float m_movementDrag = 0;


    [Header("Jump")]
    [SerializeField] private float m_jumpForce = 20;

    [Header("Ground")]
    [SerializeField] private Transform m_groundCheckOrigin;
    [SerializeField] private Vector2 m_groundCheckDir;
    [SerializeField] private LayerMask m_groundLayers;
    [SerializeField] private float m_GroundCheckDistance = 2;

    private Vector2 m_currentInput;
    private bool m_IsGrounded = false;
    private bool m_isMoving = false;
    public Rigidbody2D Rb { get => m_rb; set => m_rb = value; }
    public float Acceleration { get => m_acceleration; set => m_acceleration = value; }

    // Update is called once per frame
    private void Update()
    {
        GroundCheck();

       

     
        if (CanJump() && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
 
    }
    private void SetDrag()
    {
        if (m_IsGrounded)
        {
            if (m_isMoving)
                m_rb.drag = m_movementDrag;
            else
                m_rb.drag = m_defaultDrag;
        }
        else
        {
            m_rb.drag = m_movementDrag;
        }
    }


    

    public bool CanJump()
    {
        if (!m_IsGrounded) return false;
        return true;
    }
    private void Jump()
    {
        m_rb.AddForce(Vector2.up * m_jumpForce, ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        if (!m_IsGrounded)
            Gizmos.color = Color.red;
        Gizmos.DrawLine(m_groundCheckOrigin.position, m_groundCheckOrigin.position + (Vector3)m_groundCheckDir.normalized * m_GroundCheckDistance);
    }
    private void GroundCheck()
    {
        m_IsGrounded = false;
        RaycastHit2D raycastHit = Physics2D.Raycast(m_groundCheckOrigin.position, m_groundCheckDir, m_GroundCheckDistance, m_groundLayers);
        if (raycastHit)
        {
          m_IsGrounded = true;
        }
    }
}
