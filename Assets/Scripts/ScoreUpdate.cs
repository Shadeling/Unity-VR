using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField] int scoreMult = 1;

    private GameObject player;
    private Text text;
    private float score = 0;


    private void Start()
    {
        player = FindObjectOfType<CharControl>().gameObject;
        text = GetComponent<Text>();

        text.text = score.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score +=Time.deltaTime * scoreMult;

        text.text = ((int)score).ToString();
    }
}
