using System.Collections.Generic;
using System.Text;


namespace CCLLC.BTF.Process.CDS.Plugins
{
    static class AvailableTransactionListExtensions
    { 
        public static string Serialize(this IReadOnlyList<ITransactionType> transactionTypes)
        {
            string structure = "{{\"GroupName\":\"{0}\",\"TypeName\":\"{1}\",\"TypeId\":\"{2}\",\"Icon\":\"{3}\"}}";
            bool firstPass = true;

            var builder = new StringBuilder();
            builder.Append("[");
            foreach(var t in transactionTypes)
            {
                if (!firstPass) { builder.Append(","); }
                builder.Append(string.Format(structure, t.Group.Name, t.Name, t.Id.ToString(), "Icon_tbd"));
                firstPass = false;
            }
            builder.Append("]");

            return builder.ToString();
            
        }
    }
}
