﻿namespace CG4.Impl.Dapper.Poco.Expressions
{
    public class ExprGreaterThanOrEq : ExprBoolean
    {
        public ExprColumn Column { get; set; }

        public ExprConst Value { get; set; }

        public override void Accept(IExprVisitor visitor) => visitor.VisitGreaterThanOrEqPredicate(this);
    }
}
