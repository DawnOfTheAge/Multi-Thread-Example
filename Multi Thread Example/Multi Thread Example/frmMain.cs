using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Thread_Example
{
    public class WorkThreadParameter
    {
        public WorkThreadParameter(int iNumber, string sLine)
        {
            Number = iNumber;
            Line = sLine;
        }

        public int Number
        {
            get;
            set;
        }

        public string Line
        {
            get;
            set;
        }
    }

    public partial class frmMain : Form
    {        
        private List<Thread> m_Thread;

        private List<ThreadContext> m_ThreadContext;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            m_Thread = new List<Thread>();
            m_ThreadContext = new List<Multi_Thread_Example.ThreadContext>();
        }

        private void btnStartThreads_Click(object sender, EventArgs e)
        {
            #region Data Members

            Thread currentThread;

            ThreadContext currentThreadContext; 

            #endregion

            if (nudNumberOfThreads.Value > 0)
            {
                btnStartThreads.Visible = false;

                for (int i = 0; i < nudNumberOfThreads.Value; i++)
                {
                    currentThreadContext = new ThreadContext();
                    currentThread = new Thread(currentThreadContext.ThreadMethod);
                    currentThreadContext.ThreadReady += CurrentThreadContext_ThreadReady;
                    m_ThreadContext.Add(currentThreadContext);

                    currentThread.IsBackground = true;
                    currentThread.Name = "Thread " + (i + 1).ToString();

                    m_Thread.Add(currentThread);
                }

                for (int i = 0; i < m_Thread.Count; i++)
                {
                    m_Thread[i].Start(new WorkThreadParameter(i + 1, "I am thread number " + (i + 1).ToString()));
                }
            }
        }

        private void CurrentThreadContext_ThreadReady(object sender, EventArgs e)
        {
            int iIndex;

            iIndex = (int)sender - 1;

            m_ThreadContext[iIndex].SetWork(true);
        }

        private void btnStopThread_Click(object sender, EventArgs e)
        {
            int iIndex = (int)nudThreadToStop.Value - 1;

            m_ThreadContext[iIndex].SetWork(false);
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            int iIndex = (int)nudThreadToStop.Value - 1;

            m_ThreadContext[iIndex].SetWork(true);
        }
    }

    public class ThreadContext
    {
        public event EventHandler ThreadReady;

        private WorkThreadParameter m_WorkThreadParameter;

        private bool m_Work;

        public ThreadContext()
        {
        }

        private void OnThreadReady()
        {
            if (ThreadReady != null)
            {
                ThreadReady(m_WorkThreadParameter.Number, null);
            }
        }

        public void SetWork(bool bWork)
        {
            string sAction;

            m_Work = bWork;

            if (m_Work == false)
            {
                sAction = " Stopped";
            }
            else
            {
                sAction = " Started";
            }

            Print("Thread " + m_WorkThreadParameter.Number + sAction);
        }

        public void ThreadMethod(object oParameters)
        {            
            m_WorkThreadParameter = (WorkThreadParameter)oParameters;

            m_Work = false;

            OnThreadReady();

            while (true)
            {
                if (m_Work)
                {
                    Print(m_WorkThreadParameter.Line); 
                }

                Thread.Sleep(1000);
            }
        }

        private void Print(string sLine)
        {
            Console.WriteLine("[" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff") + "] : " + sLine);
        }
    }
}
