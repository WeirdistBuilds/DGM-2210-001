using UnityEngine;
[CreateAssetMenu(fileName = "NewMovePattern", menuName = "Scriptable Objects/SOMovePattern")]
public class SOMovePattern : ScriptableObject
{
    public SOFloat Gravity;
    
    public SOFloat MoveX, MoveY, MoveZ;
    public SOFloat RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;
    

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        Move(transform);
        Move(controller);
    }


    private void Move(CharacterController controller)
    {
        moveDirection.y = Gravity.Value;
        controller.Move(moveDirection * Time.deltaTime);
    }


    private void Move(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        transform.Rotate(rotDirection);
        moveDirection = transform.TransformDirection(moveDirection);
    }
}
