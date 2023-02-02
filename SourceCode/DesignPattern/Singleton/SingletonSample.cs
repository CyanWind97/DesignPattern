using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    
    /// <summary>
    /// 单线程单例模式
    /// 缺点：线程不安全
    /// </summary>
    public sealed class Singleton1
    {
        private static Singleton1 _instance = null;

        public static Singleton1 Instance
            => _instance ??= new ();
    }
    
    /// <summary>
    /// 简单线程安全
    /// 缺点：已创建实例，线程够多时，每个线程都要等到某一个线程退出后获得锁，会导致性能问题
    /// </summary>

    public sealed class Singleton2
    {
        private static Singleton2 _instance = null;
        private static readonly object objectLock = new Object();

        public static Singleton2 Instance
        {
            get 
            {
                lock (objectLock)
                {
                    return _instance ??= new ();
                }
            }
        } 
    }


    /// <summary>
    /// 双层验证
    /// </summary>
    public sealed class Singleton3
    {
        private static Singleton3 _instance = null;
        private static readonly object objectLock = new Object();

        public static Singleton3 Instance
        {
            get 
            {
                if(_instance != null)
                    return _instance;

                lock (objectLock)
                {
                    return _instance ??= new ();
                }
            }
        } 
    }


    /// <summary>
    /// 饿汉模式
    /// 利用静态初始化方法
    /// </summary>
    public sealed class Singleton4
    {
        private static Singleton4 _instance = new ();

        static Singleton4()
        {

        }

        public static Singleton4 Instance
            => _instance;
    }


    /// <summary>
    /// Lazy延迟实例化
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton>  _instance 
            = new (() => new());

        public static Singleton Instance
            => _instance.Value;
    }
}