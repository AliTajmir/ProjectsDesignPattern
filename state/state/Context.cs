using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace state
{
    public abstract class state
    {
        public abstract void handle(Context context);
    }
   public class Context
    {
       private state _state;
       public state state { get{return _state;} set { _state = value; } }
       public Context(state state1)
       {
           state = state1;
       }
       public void request()
       {
           MessageBox.Show("state:" + _state.GetType().Name);
           _state.handle(this);
       
       
       }
    }
   public class ConcreteStateA : state
   {



       public override void handle(Context context)
       {
           context.state = new ConcreteStateB();
       }
   }
   public class ConcreteStateB : state
   {



       public override void handle(Context context)
       {
           context.state = new ConcreteStateA();
       }
   }
}
