using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videomanager : MonoBehaviour
{
    [SerializeField]
    VideoPlayer myVideoPlayer;
    //el boutton n7ellou
    public GameObject btnplay;

    public GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        myVideoPlayer.loopPointReached += dosomething;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void dosomething(VideoPlayer vp)
    {
        btnplay.SetActive(true);
        bg.SetActive(true);

    }
}
