using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //объ€вл€ю панель проигрыша
    public GameObject gameOver;
    //объ€вл€ю текст
    public Text Live;
    //количество жизней
    public int liveScore=3; 
    //провер€ем стоим ли мы на "земле"
    public Transform groundcheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        ground = Physics2D.OverlapCircle(groundcheck.position, groundRadius, groundMask);
        //нажата ли кнопка мыши
        if (Input.GetMouseButtonDown(0)&& ground==true)
        {
            Jump();
        }
        if(liveScore==0)
        {
            gameOver.SetActive(true);
        }
    }
    public void Jump()
    {
        //высота прыжка
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
    }
    //проверка соприкосновени€ с триггером
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            liveScore--;
            Live.text = liveScore.ToString();
        }
    }
    //кнопка рестарта
    public void Restart()
    {
        SceneManager.LoadScene("Demo");
    }
}
