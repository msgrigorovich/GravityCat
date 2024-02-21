using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    public float startPosition;
    public float endPosition;
    public float levelSpeed;
    public GameObject[] levelStructure;
    public int currentLevel;

    void Start()
    {
        levelStructure[currentLevel].gameObject.transform.position = new Vector3(startPosition, 0, 0);
    }

    void FixedUpdate()
    {
        levelStructure[currentLevel].gameObject.transform.position += new Vector3(endPosition, 0, 0) * Time.fixedDeltaTime*levelSpeed;
    }
}