﻿using UnityEngine;

public static class Settings
{

    // Player Animation Parameters
    public static int xInput = Animator.StringToHash("xInput");
    public static int yInput = Animator.StringToHash("yInput");
    public static int isWalking = Animator.StringToHash("isWalking");
    public static int isRunning = Animator.StringToHash("isRunning");
    public static int toolEffect = Animator.StringToHash("toolEffect");
    public static int isUsingToolRight = Animator.StringToHash("isUsingToolRight");
    public static int isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
    public static int isUsingToolUp = Animator.StringToHash("isUsingToolUp");
    public static int isUsingToolDown = Animator.StringToHash("isUsingToolDown");
    public static int isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
    public static int isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
    public static int isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
    public static int isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
    public static int isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
    public static int isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
    public static int isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
    public static int isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
    public static int isPickingRight = Animator.StringToHash("isPickingRight");
    public static int isPickingLeft = Animator.StringToHash("isPickingLeft");
    public static int isPickingUp = Animator.StringToHash("isPickingUp");
    public static int isPickingDown = Animator.StringToHash("isPickingDown");

    // Shared Animation Parameters
    public static int idleRight = Animator.StringToHash("idleRight");
    public static int idleLeft = Animator.StringToHash("idleLeft");
    public static int idleUp = Animator.StringToHash("idleUp");
    public static int idleDown = Animator.StringToHash("idleDown");

}
