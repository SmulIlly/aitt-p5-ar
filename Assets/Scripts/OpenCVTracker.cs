using OpenCvSharp;
using OpenCvSharp.Demo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCVTracker : WebCamera
{

    private Mat image;

    protected override bool ProcessTexture(WebCamTexture input, ref Texture2D output)
    {
        image = OpenCvSharp.Unity.TextureToMat(input);

        //Processing

        if(output == null)
        {
            output = OpenCvSharp.Unity.MatToTexture(image);
            Debug.Log("I was here");
        }
        else
        {
            OpenCvSharp.Unity.MatToTexture(image, output);
            Debug.Log("I was here2");
        }

        return true;
    }
}
