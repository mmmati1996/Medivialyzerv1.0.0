using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Medivialyzerv1._0._0
{
    public class MLProcessChecker
    {
        private IntPtr m_cHandle;
        private IntPtr m_baseAddress;
        private IntPtr m_cHWND;
        private int m_pid;

        public IntPtr cHandle { get { return m_cHandle; } }
        public IntPtr baseAddress { get { return m_baseAddress; } }
        public IntPtr cHWND { get { return m_cHWND; } }
        public int pid { get { return m_pid; } }

        public MLProcessChecker(Process proc)
        {
            this.m_cHandle = proc.Handle;
            this.m_baseAddress = proc.MainModule.BaseAddress;
            this.m_cHWND = proc.MainWindowHandle;
            this.m_pid = proc.Id;
        }
    }
}
