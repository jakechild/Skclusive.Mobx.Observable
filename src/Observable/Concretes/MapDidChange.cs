namespace Skclusive.Mobx.Observable
{
    public class MapDidChange<TKey, TValue> : MapWillChange<TKey, TValue>, IMapDidChange<TKey, TValue>
    {
        public MapDidChange(TKey name, ChangeType type, TValue value, TValue oldvalue, object map) : base(name, type, value, map)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f0fb4e5a-d55d-4b1e-a792-0ed4fe2265a5" + System.Environment.NewLine);
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

        public TValue OldValue { private set; get; }

        object IMapDidChange.OldValue { get => OldValue; }
    }
}