﻿using DesignMode.SimpleFactory;
using DesignMode.Singleton;

#region 创建型模式

#region 单例模式-Singleton
////单线程下
//var singleton = Singleton.GetInstance();
//singleton.ShowMessage(Environment.CurrentManagedThreadId.ToString());
////多线程下
//for (var i = 0; i <= 5; i++)
//{
//    Task.Run(() =>
//    {
//        var singleton1 = Singleton1.GetInstance();
//        singleton1.ShowMessage(Environment.CurrentManagedThreadId.ToString());

//        var singleton2 = Singleton2.GetInstance();
//        singleton2.ShowMessage(Environment.CurrentManagedThreadId.ToString());
//    }
//    );
//}
#endregion

#region 简单工厂模式
//var sum = SumFactory.GetSum(SumType.Plus);
//sum.A = 10;
//sum.B = 5;
//Console.WriteLine(sum.GetResult());

//var sum1 = SumFactory.GetSum(SumType.Minus);
//sum1.A = 10;
//sum1.B = 5;
//Console.WriteLine(sum1.GetResult());
#endregion

#endregion