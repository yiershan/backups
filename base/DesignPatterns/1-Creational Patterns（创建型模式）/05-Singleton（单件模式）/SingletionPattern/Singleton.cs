using System;
using System.Collections.Generic;
using System.Text;

namespace SingletionPattern
{
    /// <summary>
    /// 单件模式实现方式：简单线程安全。
    /// </summary>
    public sealed class Singleton
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton _instance;

        // 定义一个标识确保线程同步
        private static readonly object _syncLock = new object();

        // 私有构造函数，防止通过new实例化对象
        private Singleton() {
        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance() {
            // 当第一个线程运行到这里时，此时会对_syncLock对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到_syncLock对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"

            // 双重锁定只需要一句判断即可
            if(_instance == null) {
                lock (_syncLock) {
                    // 使用延迟初始化
                    // 若类的实例不存在则创建实例，若存在则返回实例
                    if (_instance == null) {
                        _instance = new Singleton();
                    }
                }
            }


            return _instance;
        }
    }
}
