using System.Collections.Generic;
using System.Linq;

namespace AIPlanner
{
    /// <summary>
    /// A Method is a collection of tasks that are grouped by a common list of
    /// preconditions. The parent container the list of Methods is a 
    /// CompoundTask.
    /// </summary>
    public class Method
    {
        /// <summary>
        /// The unique name of the method.
        /// </summary>
        public string name = string.Empty;

        internal List<Condition> conditions = new List<Condition>();

        internal List<TaskReference> tasks = new List<TaskReference>();

        public override string ToString()
        {
            return $"Method {name}";
        }
    }
}