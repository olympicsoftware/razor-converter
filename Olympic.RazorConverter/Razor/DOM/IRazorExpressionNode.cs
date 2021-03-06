﻿namespace Olympic.RazorConverter.Razor.DOM
{
    public interface IRazorExpressionNode : IRazorNode
    {
        string Expression { get; }
        bool IsMultiline { get; }
    }
}
