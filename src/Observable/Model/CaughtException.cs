using System;

namespace Skclusive.Mobx.Observable
{
    public class CaughtException : Exception
    {
        public Exception Cause { get; private set; }

        public CaughtException(Exception cause) : base("CaughtException", cause)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4df763b9-2eb0-4d6c-aee9-1796103331e6" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            Cause = cause;
        }
    }
}