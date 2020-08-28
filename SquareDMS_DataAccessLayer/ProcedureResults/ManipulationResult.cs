using System;
using System.Collections.Generic;

namespace SquareDMS_DataAccessLayer.ProcedureResults
{
    public class ManipulationResult : IProcedureResult
    {
        readonly List<Tuple<Type, int, Operation>> _manipulatedEntities = new List<Tuple<Type, int, Operation>>();

        /// <summary>
        /// Result for manipulations. Contains which entities have been manipulated
        /// in which amount.
        /// </summary>
        /// <exception cref="ArgumentException">Duplicate entry added to dict.</exception>
        public ManipulationResult(int errorCode, Tuple<Type, int, Operation> manipulatedEntity,
            params Tuple<Type, int, Operation>[] manipulatedEntities)
        {
            ErrorCode = errorCode;
            _manipulatedEntities.Add(manipulatedEntity);    // Trick for at least one entry...

            foreach (var manipulation in manipulatedEntities)
            {
                _manipulatedEntities.Add(manipulation);
            }
        }

        /// <summary>
        /// Gets the manipulated amount of entities by the entity and the operation
        /// </summary>
        public int ManipulatedAmount(Type entity, Operation op)
        {
            // linear search through list
            foreach (var element in _manipulatedEntities)
            {
                if (entity.Equals(element.Item1) && op.Equals(element.Item3))
                {
                    return element.Item2;
                }
            }

            return 0;
        }

        public int ErrorCode { get; }
    }
}