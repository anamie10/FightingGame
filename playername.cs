using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playername : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject videoplayerGO;

    public VideoClip vc1;

void Start()
{
    videoplayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc1;
    videoplayerGO.gameObject.GetComponent<VideoPlayer>().Play();
}
}
