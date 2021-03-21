namespace Esprima.Ast
{
    public sealed class VariableDeclarator : Node
    {
        public Expression Id; // BindingIdentifier | BindingPattern;
        public Expression? Init;

        public VariableDeclarator(Expression id, Expression? init) :
            base(Nodes.VariableDeclarator)
        {
            Id = id;
            Init = init;
        }

        public override NodeCollection ChildNodes => new NodeCollection(Id, Init);
    }
}