using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Converts a Vector2 into a Vector3. Transformation is XY -> XZ.
    /// </summary>
    /// <param name="vector2">Value to be converted to Vector3.</param>
    /// <param name="y">Y component of the transformed vector.</param>
    /// <returns></returns>
    public static Vector3 ToVector3(this Vector2 vector2, float y = 0f)
    {
        return new Vector3(vector2.x, y, vector2.y);
    }

    /// <summary>
    /// Resets a Vector3 to (0, 0, 0).
    /// </summary>
    /// <returns>Vector after resetting components.</returns>
    public static Vector3 Reset(this Vector3 vector3)
    {
        vector3.Set(0f, 0f, 0f);
        return vector3;
    }

    /// <summary>
    /// Returns true if each component of the vectors are approximately equal to the
    /// corresponding component of the other vector.
    /// </summary>
    /// <param name="vector3">Value to compare.</param>
    /// <param name="other">Value to compare.</param>
    /// <returns>True if vectors are approximately equal.</returns>
    public static bool Approximately(this Vector3 vector3, Vector3 other)
    {
        return (vector3 - other).sqrMagnitude < 0.01;
        // return Mathf.Approximately(vector3.x, other.x)
        //        && Mathf.Approximately(vector3.y, other.y)
        //        && Mathf.Approximately(vector3.z, other.z);
    }
    
    /// <summary>
    /// Flips the variable and returns new state.
    /// </summary>
    /// <param name="b">Value to be toggled.</param>
    public static bool Toggle(this ref bool b)
    {
        b = !b;
        return b;
    }

    /// <summary>
    /// Returns 1 if true, 0 if false.
    /// </summary>
    /// <param name="b">Value to cast as integer.</param>
    /// <returns></returns>
    public static int AsInt(this bool b)
    {
        return b ? 1 : 0;
    }
}