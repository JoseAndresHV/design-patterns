using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualFacade
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            var result = new StringBuilder();
            result.Append(_subsystem1.Operation1());
            result.Append(_subsystem2.Operation2());
            result.Append(_subsystem1.OperationN());
            result.Append(_subsystem2.OperationM());

            return result.ToString();
        }
    }
}
