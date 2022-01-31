using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBackground : MonoBehaviour
{
    public float RollingSpeed;
    [SerializeField] private MeshRenderer mrenderer;
    void Start()
    {
        mrenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
      Vector2 offset = new Vector2(0,RollingSpeed * Time.time);
      mrenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
