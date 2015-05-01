using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.Custom
{
    /// <summary>
    /// Blad systemowy
    /// </summary>
    [DataContract]
    public class CustomErrorException // : Exception
    {
        [DataMember]
        public string ExceptionInfo { get; set; }

        [DataMember]
        public string ComputerName { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string ProgramName { get; set; }


        public CustomErrorException()
        {
            this.ComputerName = Environment.MachineName;
            this.UserName = Environment.UserName;
            this.ProgramName = "ASP";
        }

        public CustomErrorException(Exception ex)
            : this()
        {
            this.ExceptionInfo = ex.Message;
        }

        public CustomErrorException(string errorInfo)
            : this()
        {
            this.ExceptionInfo = errorInfo;
        }
    }
}
