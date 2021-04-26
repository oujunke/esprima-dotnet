namespace Esprima.Ast
{
    public sealed class ConditionalExpression : Expression
    {
        public Expression Test;
        public Expression Consequent;
        public Expression Alternate;

        public ConditionalExpression(
            Expression test,
            Expression consequent, 
            Expression alternate) : base(Nodes.ConditionalExpression)
        {
            Test = test;
            Consequent = consequent;
            Alternate = alternate;
        }

        public override NodeCollection ChildNodes => new NodeCollection(Test, Consequent, Alternate);
    }
}