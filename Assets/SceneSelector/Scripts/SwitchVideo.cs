using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class SwitchVideo : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private VideoClip _clip;
    private VideoPlayer _player;

    private void Start()
    {
        _player = GameObject.Find("Video").GetComponent<VideoPlayer>();
    }

    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _player.clip = _clip;
        _player.Play();
    }
    
}
