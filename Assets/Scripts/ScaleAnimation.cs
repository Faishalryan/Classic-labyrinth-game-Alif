using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu(fileName = "Scale Animation", menuName = "Custom Asset/Animation/Scale")]
public class ScaleAnimation : BaseAnimation
{
    public override void Animate(Transform visual)
    {
        base.Animate(visual);

        visual.parent.DOScale(2.0f, base.duration).SetLoops(-1, LoopType.Yoyo);
    }
}
