using DesignMode.AbstractFactory;
using DesignMode.AbstractFactory.FactoryNo1;
using DesignMode.AbstractFactory.FactoryNo2;
using DesignMode.FactoryMethod;
using DesignMode.SimpleFactory;
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

#region 工厂方法模式
//var plus = new PlusFactory().CreateSum();
//plus.A = 10;
//plus.B = 5;
//Console.WriteLine(plus.GetResult());

//var minus = new MinusFactory().CreateSum();
//minus.A = 10;
//minus.B = 5;
//Console.WriteLine(minus.GetResult());

//var multiply = new MultiplyFactory().CreateSum();
//multiply.A = 10;
//multiply.B = 5;
//Console.WriteLine(multiply.GetResult());
#endregion


#region 抽象工厂模式
AbstractFactory factoryNo1 = new ConcreteFactoryNo1(); 
var productAFromFacNo1 =  factoryNo1.CreateProductA();
productAFromFacNo1.ShowName();
var productBFromFacNo1 = factoryNo1.CreateProductB();
productBFromFacNo1.ShowName();

AbstractFactory factoyrNo2 = new ConcreteFactoryNo2();
var productAFromFacNo2 = factoyrNo2.CreateProductA();
productAFromFacNo2.ShowName();
var productBFromFacNo2 = factoyrNo2.CreateProductB();
productBFromFacNo2.ShowName();
#endregion
#endregion