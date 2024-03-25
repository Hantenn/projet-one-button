using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class saaaaaa : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rb;
    [SerializeField] private float m_speed = 10;


    [Header("Jump")]
    [SerializeField] private float m_jumpForce = 20;

    [Header("Ground")]
    [SerializeField] private Transform m_groundCheckOrigin;
    [SerializeField] private GameObject m_groundCheckOrigingameobject;
    [SerializeField] private Vector2 m_groundCheckDir;
    [SerializeField] private LayerMask m_groundLayers;
    [SerializeField] private float m_GroundCheckDistance = 2;

    public GameObject colliderr;
    public GameObject anim;
    private Vector2 m_currentInput;
    public bool m_IsGrounded = false;
    public Rigidbody2D Rb { get => m_rb; set => m_rb = value; }
    private float currentHeight = 0f;
    private float previousHeight = 0f;
    public AnimationClip anima;
    public bool cbon = false;
    void Start()
    {
    }
    // Update is called once per frame
    private void Update()
    {
        colliderr.SetActive(false);
        transform.Translate(Vector2.right * m_speed * Time.deltaTime);
        GroundCheck();

        currentHeight = transform.position.y;

        if (m_IsGrounded && !Input.GetKeyDown(KeyCode.Space))
        {
            anim.GetComponent<Animator>().SetTrigger("run");
            anim.GetComponent<Animator>().ResetTrigger("jump");
            anim.GetComponent<Animator>().ResetTrigger("fall");
            anim.GetComponent<Animator>().ResetTrigger("attack");
            cbon = false;
        }
        if ((!m_IsGrounded && Input.GetKeyDown(KeyCode.Space)) || m_groundCheckOrigingameobject.activeSelf == false && Input.GetKeyDown(KeyCode.Space))
        {
            cbon = true;
            anim.GetComponent<Animator>().PlayInFixedTime("attack",0,1.2f);
            colliderr.SetActive(true);
            anim.GetComponent<Animator>().SetTrigger("attack");
            anim.GetComponent<Animator>().ResetTrigger("jump");
            anim.GetComponent<Animator>().ResetTrigger("fall");
            anim.GetComponent<Animator>().ResetTrigger("run");
           
        }
        if ((CanJump() && Input.GetKeyDown(KeyCode.Space)))
        {
            Jump();
        }
        if (currentHeight > previousHeight && !m_IsGrounded)
        {
            anim.GetComponent<Animator>().SetTrigger("jump");
            anim.GetComponent<Animator>().ResetTrigger("run");
            anim.GetComponent<Animator>().ResetTrigger("fall");
            anim.GetComponent<Animator>().ResetTrigger("attack");
            cbon = false;
        }
        else if (currentHeight < previousHeight && !m_IsGrounded)
        {
            anim.GetComponent<Animator>().SetTrigger("fall");
            anim.GetComponent<Animator>().ResetTrigger("jump");
            anim.GetComponent<Animator>().ResetTrigger("run");
            anim.GetComponent<Animator>().ResetTrigger("attack");
            cbon = false;
        }

        previousHeight = currentHeight;
        GroundCheck();
    }
    public bool CanJump()
    {
        if ((m_IsGrounded) && m_groundCheckOrigingameobject.activeSelf == true) {
            return true;
        }
        return false;
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

    private void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log(cbon);
        if ((collider.tag == "destroyable") && cbon == true)
        {
            Destroy(collider.gameObject);
        }
        else if ((collider.tag == "bomb") && cbon == true)
        {
            SceneManager.LoadScene("death");
        }
    }
}
