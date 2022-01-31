using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float RollingSpeed;
    [SerializeField] private MeshRenderer mrenderer;
    void Start()
    {
        mrenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
      Vector2 offset = new Vector2(0,RollingSpeed);
      mrenderer.sharedMaterial.SetTextureOffset("",offset);
    }
}
