using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool isGrounded = false;
    bool gravity = false;
    //метод при старте игры
    void Start()
    {
        Physics.gravity = new Vector3(0, -100f, 0);
    }
    //метод когда объект входит из треггер зоны
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death") SceneManager.LoadScene(0);
    }
    //метод когда объект находится
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground") isGrounded = true;
    }
    //метод когда объект выходит из треггер зоны
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground") isGrounded = false;
    }
    //метод отрабатывающий каждый кадр
    void Update()
    {
        if (isGrounded == true)
        {
            if (Input.GetMouseButtonDown(0) & gravity == false)
            {
                Physics.gravity = new Vector3(0, 100f, 0);
                gravity = true;
                State = States.AnimationUngravity; // переход стэйта аниматора при прыжке
            }
            else if (Input.GetMouseButtonDown(0) & gravity == true)
            {
                Physics.gravity = new Vector3(0, -100f, 0);
                gravity = false;
                State = States.DefaultAnimation; // возврат дефолтного стэйта аниматора при обратном приземлении
            }
        }
    }

    // создаем поле аниматора
    private Animator anim;

    // получаем ссылку на компонент аниматора
    private void Awake ()
    {
        anim = GetComponent<Animator>();
    }

    // поле для получения и установки стэйта из аниматора
    private States State
    {
        get {return (States)anim.GetInteger("State");}
        set {anim.SetInteger("State", (int)value);}
    }

}

// создем константы состояний для аниматора
// обязательно в том порядке, в котором они создавались в аниматоре
public enum States
{
    DefaultAnimation,
    AnimationUngravity
}
