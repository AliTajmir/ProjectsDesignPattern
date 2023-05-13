using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public interface IPersonState
    {
        void state();
    }
    public class Employee : IPersonState
    {
        public void state()
        {
            MessageBox.Show("Here is the employee");
        }
    }
    public abstract class Decorator : IPersonState
    {
        IPersonState _person;
        public Decorator(IPersonState person)
        {
            _person = person;
        }
        public virtual void state()
        {
            _person.state();
        }
    }

    public class ConcreteDecorator: Decorator
    {
        public ConcreteDecorator(IPersonState personState):base(personState)
        {

        }
        
        public override void state()
        {
            base.state();
            MessageBox.Show("Here is the ConcreteDecorator");
        }
    }

}
