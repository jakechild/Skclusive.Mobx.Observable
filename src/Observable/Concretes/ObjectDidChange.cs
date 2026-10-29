namespace Skclusive.Mobx.Observable
{
    public class ObjectDidChange<T> : ObjectWillChange<T>, IObjectDidChange<T>
    {
        public ObjectDidChange(string name, ChangeType type, T value, T oldvalue, object objectx) : base(name, type, value, objectx)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0a15c17d-a09b-485a-b162-6c7297d782e5" + System.Environment.NewLine);
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

        public T OldValue { private set; get; }

        object IObjectDidChange.OldValue { get => OldValue; }
    }
}