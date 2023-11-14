using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(SpriteRenderer))]
public class Animation : MonoBehaviour
{
    private SpriteRenderer sr;
    private SAClip currentClip;
    private float lastFrameUpdateTime;
    private int frameIndex;
    private SAClip[] clips;
    private float animationInterval;
    [Range(0.1f, 10f)]
    public float fpsScale = 1f;
    private PlayerDinamic player;

    
    void Start()
    {
         
        sr = GetComponentInChildren<SpriteRenderer>();
        clips = GetComponents<SAClip>();
        player = GameObject.FindObjectOfType<PlayerDinamic>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (player.jump == false)
        {
            if (x > 0)
            {
                StartAnimation("right");
                fpsScale = x;
            }
            else if (x < 0)
            {
                StartAnimation("left");
                fpsScale = Mathf.Abs(x);
            }
            else
            {
                if (currentClip?.clipName == "left" || currentClip?.clipName == "idle_left" || currentClip?.clipName == "jump_left") StartAnimation("idle_left");
                else StartAnimation("idle_right");
                fpsScale = 1;
            }
        }
        else
        {
            if (player.GetComponent<Rigidbody2D>().velocity.x > 0) StartAnimation("jump_right");
            else if (player.GetComponent<Rigidbody2D>().velocity.x < 0) StartAnimation("jump_left");
            else if (currentClip?.clipName == "idle_left" || currentClip?.clipName == "jump_left") StartAnimation("jump_left");
            else StartAnimation("jump_right");
        }


        ShowFrame();
        if (lastFrameUpdateTime == 0 || Time.time > lastFrameUpdateTime + animationInterval / fpsScale)
        {
            lastFrameUpdateTime = Time.time;
            NextFrame();
        }
    }

    public void StartAnimation(string clipName)
    {
        SAClip newCurrentClip = clips.Where(clip => clip.clipName == clipName).FirstOrDefault();
       // Debug.Log(clipName);
        if (newCurrentClip == null) return;
        if (newCurrentClip.clipName != currentClip?.clipName) frameIndex = 0;
        currentClip = newCurrentClip;
        if (currentClip == null) Debug.LogError("Не найден клип " + clipName);
        else
        {
            animationInterval = 1 / currentClip.fps;
        }
    }

    public void StopAnimation()
    {
        currentClip = null;
    }

    private void ShowFrame()
    {
        if (currentClip != null)
        {
            sr.sprite = currentClip.frames[frameIndex % currentClip.frames.Length];
        }
    }

    private void NextFrame()
    {
        if (currentClip != null)
        {
            frameIndex++;
            if (!currentClip.loop)
            {
                frameIndex = Mathf.Clamp(frameIndex, 0, currentClip.frames.Length - 1);
            }
        }
    }
}
