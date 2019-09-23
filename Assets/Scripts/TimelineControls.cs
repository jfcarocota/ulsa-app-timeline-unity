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

    double timelineFrames;

    // Start is called before the first frame update
    void Awake()
    {
        timelineFrames = playableDirector.duration * 60;
        btnPlayTimeline.onClick.AddListener(PlayTimeline);
        btnPauseTimeline.onClick.AddListener(PauseTimeline);
        btnStopTimeline.onClick.AddListener(StopTimeline);
        Debug.Log(playableDirector.duration);
        Debug.Log(timelineFrames);
    }

    void Update()
    {
        Debug.Log(playableDirector.time);
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
}
