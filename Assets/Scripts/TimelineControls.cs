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

    // Start is called before the first frame update
    void Awake()
    {
        timelineFrames = (float)playableDirector.duration * 60;
        btnPlayTimeline.onClick.AddListener(PlayTimeline);
        btnPauseTimeline.onClick.AddListener(PauseTimeline);
        btnStopTimeline.onClick.AddListener(StopTimeline);
        Debug.Log(playableDirector.duration);
        Debug.Log(timelineFrames);
        timelineUI.maxValue = (float)playableDirector.duration;
        timelineUI.onValueChanged.AddListener(delegate{ValueChnaged();});
    }

    void Update()
    {
        //Debug.Log(playableDirector.time);
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
}
