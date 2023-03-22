using System;

namespace DesignMode.Singleton
{
    /// <summary>
    /// 单线程可行操作
    /// </summary>
    public class Singleton
    {
        private Guid _guid;
        private static Singleton instance;
        /// <summary>
        /// 构造函数私有化，防止外界创建新对象
        /// </summary>
        private Singleton(Guid guid)
        {
            _guid = guid;
        }
        public static Singleton GetInstance()
        {
            Guid guid = Guid.NewGuid();
            return instance ?? new Singleton(guid);
        }

        public void ShowMessage(string threadId)
        {
            Console.WriteLine("This is a Singleton，InstanceId：" + _guid.ToString() + "，ThreadId：" + threadId);
        }
    }

    /// <summary>
    /// 多线程可行操作（lock锁）
    /// </summary>
    public class Singleton1
    {
        private Guid _guid;
        private static Singleton1 instance;
        private static readonly object myLock = new();
        /// <summary>
        /// 构造函数私有化，防止外界创建新对象
        /// </summary>
        private Singleton1(Guid guid)
        {
            _guid = guid;
        }

        public static Singleton1 GetInstance()
        {
            lock (myLock)
            {
                Guid guid = Guid.NewGuid();
                return instance ??= new Singleton1(guid);
            }
        }
        public void ShowMessage(string threadId)
        {
            Console.WriteLine("This is a Singleton1，InstanceId：" + _guid.ToString() + "，ThreadId：" + threadId);
        }
    }

    /// <summary>
    /// 多线程可行操作（双重lock锁）
    /// </summary>
    public class Singleton2
    {
        private Guid _guid;
        private static Singleton2 instance;
        /// <summary>
        /// //构造函数私有化，防止外界创建新对象
        /// </summary>
        private Singleton2(Guid guid)
        {
            _guid = guid;
        }
        private static readonly object myLock = new();

        public static Singleton2 GetInstance()
        {
            if (instance == null)
            {
                lock (myLock)
                {
                    Guid guid = Guid.NewGuid();
                    instance ??= new Singleton2(guid);
                }
            }
            return instance;
        }
        public void ShowMessage(string threadId)
        {
            Console.WriteLine("This is a Singleton2，InstanceId：" + _guid.ToString() + "，ThreadId：" + threadId);
        }
    }
}
