using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    public Text txtScore;
    public GameObject ganhouOjogo;
    float score = 100;
    public void AddPoint()
    {
        score += 100;
        txtScore.text = score.ToString();
    }
    public void GanhouJogo()
    {
        ganhouOjogo.SetActive(true);
    }
}
