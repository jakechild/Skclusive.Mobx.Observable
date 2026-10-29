namespace Skclusive.Mobx.Observable
{
    public class ValueDidChange<T> : ValueWillChange<T>, IValueDidChange<T>
    {
        public ValueDidChange(T value, T oldvalue, object objectx) : base(value, objectx)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a09e2e43-cfe6-4e7d-8315-8bd746e43503" + System.Environment.NewLine);
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
            OldValue = oldvalue;
        }

        T IValueDidChange<T>.OldValue { get => (T)OldValue; }
        public object OldValue { private set; get; }
    }
}