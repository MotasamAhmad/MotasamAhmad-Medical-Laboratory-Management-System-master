using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Medical_Laboratory_Management_System.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Login))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Login);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Main m_Main;

            public Main Main
            {
                [DebuggerHidden]
                get
                {
                    m_Main = Create__Instance__(m_Main);
                    return m_Main;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Main))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Main);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Report m_Report;

            public Report Report
            {
                [DebuggerHidden]
                get
                {
                    m_Report = Create__Instance__(m_Report);
                    return m_Report;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Report))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Report);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Search m_Search;

            public Search Search
            {
                [DebuggerHidden]
                get
                {
                    m_Search = Create__Instance__(m_Search);
                    return m_Search;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Search))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Search);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Start m_Start;

            public Start Start
            {
                [DebuggerHidden]
                get
                {
                    m_Start = Create__Instance__(m_Start);
                    return m_Start;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Start))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Start);
                }
            }

        }


    }
}