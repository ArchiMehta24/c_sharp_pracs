using System;

namespace practicalsA
{
	class A
	{
    	//virtual is like starting point. next classes cna redefine.
    	public virtual void display()
    	{
        		Console.WriteLine("in A");
    	}
	}

	class B:A
	{
    	//override means next. till the sublcasses ahve the override metnod the chain keeps on going.
    	public new virtual void display()
    	{
        		Console.WriteLine("in B class");
    	}
	}

	class C : B
	{
    	public override void display()
    	{
        		Console.WriteLine("in C");
    	}
	}

	class D : C
	{
    	//new keyword methods have nothing to do with the previous ones.
    	public new virtual void display()
    	{
        		Console.WriteLine("in D");
    	}
	}

	class E : D
	{
    	public override void display()
    	{
        		Console.WriteLine("in E");
    	}
	}

	internal class Program
	{
    	static void Main(string[] args)
    	{
        	A a = new E();
        	a.display();

        	D d = new E();
        	d.display();

        	B b = new C();
        	b.display();
        	Console.WriteLine("Hello, World!");
        	Console.ReadKey();
    	}
	}
}
