using UnityEngine;

public class IntegerInputNode : InputNode {
    public IntegerInputNode(Node parent) {
        InputType = typeof(int);
        ParentNodeReference = parent;
    }
    
    public override bool CanAcceptNode(OutputNode outputNode) {
        if (outputNode.OutputType == InputType) return true;
        if (outputNode.OutputType == typeof(sbyte)
            || outputNode.OutputType == typeof(byte)
            || outputNode.OutputType == typeof(short)
            || outputNode.OutputType == typeof(ushort)
            || outputNode.OutputType == typeof(float)
            || outputNode.OutputType == typeof(uint)
            || outputNode.OutputType == typeof(long)
            || outputNode.OutputType == typeof(ulong)
            || outputNode.OutputType == typeof(double)
            || outputNode.OutputType == typeof(decimal)) {
            Debug.LogWarning($"OutputNode of type {outputNode.OutputType.Name} will be converted to {typeof(int).Name}");
            return true;
        }
        return false;
    }
}