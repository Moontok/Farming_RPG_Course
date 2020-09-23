// public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying,
// ToolEffect toolEffect, 
// bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
// bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
// bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
// bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
// bool idleUp, bool idleDown, bool idleRight, bool idleLeft
// );

// public static class EventHandler
// {
//     // Movement Event

//     public static event MovementDelegate MovementEvent;

//     // Movement Event Call for Publishers
//     public static void CallMovementEvent()
//     {
//         if(MovementEvent != null)
//         {

//         }
//     }
// }

public enum ToolEffect { none, Watering }
public enum PlayerState { Idle, Walking, Running }
public enum PlayerAction { Idle, UsingTool, LiftingTool, Picking, SwingingTool }
public enum PlayerActionDirection { Left, Right, Up, Down }

public delegate void MovementDelegate(float inputX, float inputY, 
PlayerState playerState, PlayerAction playerAction, PlayerActionDirection playerActionDirection,
bool isCarrying, ToolEffect toolEffect);
