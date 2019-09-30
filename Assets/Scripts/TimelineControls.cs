using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class TimelineControls : MonoBehaviour
{
    [SerializeField]
    PlayableDirector playableDirector;

    [SerializeField]
    Button btnPlayTimeline;
    [SerializeField]
    Button btnPauseTimeline;
    [SerializeField]
    Button btnStopTimeline;

    float timelineFrames;

    [SerializeField]
    Slider timelineUI;

    [SerializeField]
    Button btnSkippRight;
    [SerializeField]
    Button btnSkippLeft;

    void Awake()
    {
        timelineFrames = (float)playableDirector.duration * 60;

        btnPlayTimeline.onClick.AddListener(PlayTimeline);
        btnPauseTimeline.onClick.AddListener(PauseTimeline);
        btnStopTimeline.onClick.AddListener(StopTimeline);

        btnSkippRight.onClick.AddListener(SkippRight);
        btnSkippLeft.onClick.AddListener(SkippLeft);

        timelineUI.maxValue = (float)playableDirector.duration;
        timelineUI.onValueChanged.AddListener(delegate{ValueChnaged();});
    }

    void Update()
    {
        timelineUI.value = (float)playableDirector.time;
    }
    void PlayTimeline()
    {
        playableDirector.Play();
    }

    void PauseTimeline()
    {
        playableDirector.Pause();
    }

    void StopTimeline()
    {
        playableDirector.Stop();
    }

    void ValueChnaged()
    {
        playableDirector.time = (double) timelineUI.value;
    }

    void SkippRight()
    {
        playableDirector.time +=  2;
    }

    void SkippLeft()
    {
        playableDirector.time -=  2;
    }
}
