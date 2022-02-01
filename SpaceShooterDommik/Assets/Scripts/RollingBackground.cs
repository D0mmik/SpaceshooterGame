using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBackground : MonoBehaviour
{
    public float rollingSpeed;
    public MeshRenderer mrenderer;
    void Start()
    {
      mrenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
      Vector2 offset = new Vector2(0,rollingSpeed * Time.time);
      mrenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
