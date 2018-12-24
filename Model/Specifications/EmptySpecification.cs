﻿using System;
using System.Linq.Expressions;


namespace Model.Specifications
{
    public class EmptySpecification<T> : Specification<T>
    {

        public override Expression<Func<T, bool>> ToExpression()
        {
            return movie => true;
        }
    }
}
