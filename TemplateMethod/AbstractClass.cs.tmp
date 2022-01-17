/**
 * @(#) AbstractClass.cs
 */

using System;

namespace TemplateMethod
{
	public abstract class AbstractClass
	{
		public void TemplateMethod(  )
		{
			Operation1();
			if(HookOperation2())
            {
				Operation2();
            }
			Operation3();
		}
		
		public void Operation1(  )
		{
			Console.WriteLine("Shared operation for all classes");
		}
		
		public abstract void Operation2(  );
		
		public virtual bool HookOperation2(  )
		{
			return false;
		}
		
		public abstract void Operation3(  );
		
	}
	
}
