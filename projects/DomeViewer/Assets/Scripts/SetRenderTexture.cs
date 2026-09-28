using Klak.Ndi;
using Klak.Spout;
using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;
using pfc.Fulldome;

public class SetRenderTexture : MonoBehaviour
{
    public NdiReceiver ndiReceiver;
    public VideoPlayer videoPlayer;
    public SpoutReceiver spoutReceiver;
    public SetImageTexture imageTexture;
    public GIController globalIlluminationController;

    public List<RenderTexture> renderTextures;

    public void SetRenderTextureByIndex(int index)
    {
        if (index < 0 || index >= renderTextures.Count)
        {
            Debug.LogError("Index out of range for renderTextures list.");
            return;
        }
        RenderTexture selectedRenderTexture = renderTextures[index];
        if (ndiReceiver != null)
        {
            ndiReceiver.targetTexture = selectedRenderTexture;
        }
        if (videoPlayer != null)
        {
            videoPlayer.targetTexture = selectedRenderTexture;
        }
        if (spoutReceiver != null)
        {
            spoutReceiver.targetTexture = selectedRenderTexture;
        }
        if (imageTexture != null)
        {
            imageTexture.target = selectedRenderTexture;
        }
        if (globalIlluminationController != null)
        {
            globalIlluminationController.source = selectedRenderTexture;
        }
    }

}
