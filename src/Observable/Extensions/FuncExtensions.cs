using System;

namespace Skclusive.Mobx.Observable
{
    public static class FuncExtensions
    {
#region Packs
        public static Func<object[], object> Pack<R>(this Func<R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e2379f66-9d8d-4cd2-9b93-9a0f63163cee" + System.Environment.NewLine);
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
            return args => action();
        }

        public static Func<object[], object> Pack<A1, R>(this Func<A1, R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e31f8beb-4893-4263-bd78-7992a2daa7d0" + System.Environment.NewLine);
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
            return args => action((A1)args[0]);
        }

        public static Func<object[], object> Pack<A1, A2, R>(this Func<A1, A2, R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b8711561-4d6c-43a2-bbb3-04f5c3a04015" + System.Environment.NewLine);
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
            return args => action((A1)args[0], (A2)args[1]);
        }

        public static Func<object[], object> Pack<A1, A2, A3, R>(this Func<A1, A2, A3, R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9bf48313-7d97-4093-bb07-65b81fd330c5" + System.Environment.NewLine);
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
            return args => action((A1)args[0], (A2)args[1], (A3)args[2]);
        }

        public static Func<object[], object> Pack<A1, A2, A3, A4, R>(this Func<A1, A2, A3, A4, R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "eecaad9e-e406-4338-bcf8-ed65a7477dd4" + System.Environment.NewLine);
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
            return args => action((A1)args[0], (A2)args[1], (A3)args[2], (A4)args[3]);
        }

        public static Func<object[], object> Pack<A1, A2, A3, A4, A5, R>(this Func<A1, A2, A3, A4, A5, R> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e19d6361-29b7-4832-ab4a-7866876d7dd7" + System.Environment.NewLine);
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
            return args => action((A1)args[0], (A2)args[1], (A3)args[2], (A4)args[3], (A5)args[4]);
        }

#endregion
#region Unpack
        public static Func<R> Unpack<R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "18e57ba5-7465-43c8-b5fb-99db2580f9ba" + System.Environment.NewLine);
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
            return () => (R)action(null);
        }

        public static Func<A1, R> Unpack<A1, R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "accdac11-ab28-4bf8-8990-57916cc01c0e" + System.Environment.NewLine);
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
            return (A1 arg1) => (R)action(new object[] { arg1 });
        }

        public static Func<A1, A2, R> Unpack<A1, A2, R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "576c61a6-9b91-4680-af7b-b711ab445b38" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2) => (R)action(new object[] { arg1, arg2 });
        }

        public static Func<A1, A2, A3, R> Unpack<A1, A2, A3, R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "75df0933-4dda-4fad-b78c-a1e4774ae82c" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3) => (R)action(new object[] { arg1, arg2, arg3 });
        }

        public static Func<A1, A2, A3, A4, R> Unpack<A1, A2, A3, A4, R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d84fe0e3-742c-4a4e-b672-596273a9c489" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3, A4 arg4) => (R)action(new object[] { arg1, arg2, arg3, arg4 });
        }

        public static Func<A1, A2, A3, A4, A5, R> Unpack<A1, A2, A3, A4, A5, R>(this Func<object[], object> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4dbececf-5aca-4c8c-94d8-e55431435cc2" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5) => (R)action(new object[] { arg1, arg2, arg3, arg4, arg5 });
        }
#endregion
    }
}