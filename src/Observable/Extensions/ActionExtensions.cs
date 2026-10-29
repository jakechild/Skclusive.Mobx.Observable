using System;

namespace Skclusive.Mobx.Observable
{
    public static class ActionExtensions
    {
#region Packs
        public static Action<object[]> Pack(this Action action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "60ca19d0-7a12-4b5b-883f-f873367b6f8d" + System.Environment.NewLine);
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

        public static Action<object[]> Pack<A1>(this Action<A1> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7df6de31-7518-409a-8da7-b4484c57eb40" + System.Environment.NewLine);
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

        public static Action<object[]> Pack<A1, A2>(this Action<A1, A2> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2f9960fe-4f3c-41d8-a676-08bb75ea0219" + System.Environment.NewLine);
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

        public static Action<object[]> Pack<A1, A2, A3, A4>(this Action<A1, A2, A3, A4> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dd39d99a-855b-469f-abf9-2e84dfef6512" + System.Environment.NewLine);
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

        public static Action<object[]> Pack<A1, A2, A3>(this Action<A1, A2, A3> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f438be23-8962-46eb-9ab9-6d5128904251" + System.Environment.NewLine);
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

        public static Action<object[]> Pack<A1, A2, A3, A4, A5>(this Action<A1, A2, A3, A4, A5> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1b33c1d4-8370-4347-9a1c-1602622656ec" + System.Environment.NewLine);
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
        public static Action Unpack(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "32d11ba9-b64c-4d53-92b4-24aba50d7299" + System.Environment.NewLine);
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
            return () => action(null);
        }

        public static Action<A1> Unpack<A1>(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f07bfa53-6545-4ae3-a099-431717eee1f5" + System.Environment.NewLine);
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
            return (A1 arg1) => action(new object[] { arg1 });
        }

        public static Action<A1, A2> Unpack<A1, A2>(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e10f8763-0790-45cc-8b24-a7667a19efb2" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2) => action(new object[] { arg1, arg2 });
        }

        public static Action<A1, A2, A3> Unpack<A1, A2, A3>(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "70ccf86d-7f28-41eb-93cf-8e057b2bf096" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3) => action(new object[] { arg1, arg2, arg3 });
        }

        public static Action<A1, A2, A3, A4> Unpack<A1, A2, A3, A4>(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "46a9503a-1a1a-441c-8967-a023c2757756" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3, A4 arg4) => action(new object[] { arg1, arg2, arg3, arg4 });
        }

        public static Action<A1, A2, A3, A4, A5> Unpack<A1, A2, A3, A4, A5>(this Action<object[]> action)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e987caab-b03a-490a-a2fb-cfb00371a477" + System.Environment.NewLine);
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
            return (A1 arg1, A2 arg2, A3 arg3, A4 arg4, A5 arg5) => action(new object[] { arg1, arg2, arg3, arg4, arg5 });
        }
#endregion
    }
}