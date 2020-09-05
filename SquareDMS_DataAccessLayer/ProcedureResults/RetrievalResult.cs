using SquareDMS_DataAccessLayer.Entities;
using System.Collections.Generic;

namespace SquareDMS_DataAccessLayer.ProcedureResults
{
    /// <summary>
    /// Result with Resultset
    /// </summary>
    public class RetrievalResult<T> : IProcedureResult where T : IEntity
    {
        /// <param name="errorCode">Error Code for the Procedure.</param>
        /// <param name="resultset">Retrieved entities</param>
        public RetrievalResult(int errorCode, IEnumerable<T> resultset)
        {
            ErrorCode = errorCode;
            Resultset = resultset;
        }

        public IEnumerable<T> Resultset { get; }

        public int ErrorCode { get; }
    }
}
