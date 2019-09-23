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

    // Start is called before the first frame update
    void Awake()
    {
        btnPlayTimeline.onClick.AddListener(PlayTimeline);
        btnPauseTimeline.onClick.AddListener(PauseTimeline);
        btnStopTimeline.onClick.AddListener(StopTimeline);
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
