using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rising_P : StateMachineBehaviour
{
    [SerializeField] AvatarTarget targetBodyPart = AvatarTarget.Root;
    [SerializeField, Range(0, 1)] float start = 0, end = 1;

    [HeaderAttribute("match target")]
    public Vector3 matchPosition;
    public Quaternion matchRotation;

    [HeaderAttribute("Weights")]
    public Vector3 positionWeight = Vector3.one;
    public float rotationWight = 0;

    private MatchTargetWeightMask weightMask;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        weightMask = new MatchTargetWeightMask(positionWeight, rotationWight);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, start, end);
    }
}
