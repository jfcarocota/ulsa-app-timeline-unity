using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    Button btnPlayTimeline;
    [SerializeField]
    PlayableDirector playableDirector;

    void Awake()
    {
        btnPlayTimeline = GetComponent<Button>();
        btnPlayTimeline.onClick.AddListener(ButtonPlayTimeline);
    }

    void ButtonPlayTimeline()
    {
        Debug.Log("Play timeline");
        playableDirector.Play();
    }
}
