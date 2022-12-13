using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSkinSet : MonoBehaviour
{
    SkeletonAnimation SkeletonAnim;
    [SerializeField] string skinId;
    void Start()
    {
        SkeletonAnim = GetComponent<SkeletonAnimation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SkeletonAnim.Skeleton.SetSkin(skinId);
            
        }
    }
}
