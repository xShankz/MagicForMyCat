using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int HP = 100;
    private int hp;
    public int Enemigo01 = 10;
    public int Enemigo02 = 23;
    public int Enemigo03 = 100;
    public Animator Anim;
    private bool movimiento = true;
    public float velocidad = 5f;
    Rigidbody2D rb;
    private Vector2 posicionInicial;
    void Start()
    {
        hp = HP;
        rb = GetComponent<Rigidbody2D>();
        //Application.targetFrameRate = 60;
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (movimiento == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector2(rb.velocity.x, velocidad);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector2(rb.velocity.x, -velocidad);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector2(-velocidad, rb.velocity.y);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    rb.velocity = new Vector2(velocidad, rb.velocity.y);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                Anim.SetBool("Caminar", true);
            }
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                Anim.SetBool("Caminar", false);
            }
            if (Input.GetKey(KeyCode.E))
            {
                Anim.SetBool("Atacar", true);
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                Anim.SetBool("Atacar", false);
            }
        }
        if (HP <= 0)
        {
            Anim.SetBool("Muerte", true);
            Invoke("Reinicio",2.1f);
            movimiento = false;
        }
    }

    void Reinicio()
    {
        transform.position = posicionInicial;
        HP = hp;
        Anim.SetBool("Muerte", false);
        movimiento = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo01"))
        {
            HP -= Enemigo01;
        }
        if (collision.gameObject.CompareTag("Enemigo02"))
        {
            HP -= Enemigo02;
        }
        if (collision.gameObject.CompareTag("Enemigo03"))
        {
            HP -= Enemigo03;
        }
    }
}