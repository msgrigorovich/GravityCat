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
            }
            else if (Input.GetMouseButtonDown(0) & gravity == true)
            {
                Physics.gravity = new Vector3(0, -100f, 0);
                gravity = false;
            }
        }
    }
}
