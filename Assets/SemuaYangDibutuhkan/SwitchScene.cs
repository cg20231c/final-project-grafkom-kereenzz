using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class SwitchScene: MonoBehaviour
{
    public PlayableDirector Timeline; // Reference to your timeline

    void Start()
    {
        Timeline = GetComponent<PlayableDirector>(); // Get the PlayableDirector component
        Timeline.stopped += OnTimelineFinished; // Subscribe to timeline finished event
        Timeline.Play(); // Start playing the timeline
    }

    void OnTimelineFinished(PlayableDirector director)
    {
        SceneManager.LoadScene("maingame"); // Load the MainGame scene when the timeline finishes
    }
}
