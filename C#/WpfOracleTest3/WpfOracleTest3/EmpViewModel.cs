using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOracleTest3
{
    public class EmpViewModel
    {
        int empno = 0;
        string ename = string.Empty;
        string job = string.Empty;

        //public 프로퍼티
        public int Empno
        {
            get { return empno; }
            set { this.Empno = value; }
        }

        //public 프로퍼티
        public string Ename
        {
            get { return ename; }
            set { this.Ename = value; }
        }

        //public 프로퍼티
        public string Job
        {
            get { return job; }
            set { this.Job = value; }
        }
    }
}
