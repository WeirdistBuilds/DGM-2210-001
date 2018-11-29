using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedProjector : MonoBehaviour {

    public float fps = 30.0f;
    public Texture2D[] frames;

    private int frameIndex;
    private Projector projector;

    private void Start()
    {
        projector = GetComponent<Projector>();
        NextFrame();
        InvokeRepeating("NextFrame", 1 / fps, 1 / fps);
    }

    void NextFrame()
    {
        projector.material.SetTexture("_ShadowTex", frames[frameIndex]);
        if (frameIndex >= frames.Length - 1)
        {
            frameIndex = 0;
        }
        else
        {
            frameIndex++;
            Debug.Log(frameIndex.ToString());
        }
    }
}
