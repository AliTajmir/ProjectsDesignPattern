using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace factory
{
   public interface IAnimal
    {
       void speak();
    }

   public class cat:IAnimal
   {

       public void speak()
       {
           MessageBox.Show("cat:i am cat");
       }
   }

   public class dog:IAnimal
   {

       public void speak()
       {
           MessageBox.Show("dog:i am dog");
       }
   }

   public static class factory
   {
      static IAnimal animal = null;
       public static IAnimal method_factory(string name)
       {
            
           switch (name.ToLower())
           {
               case "cat":animal= new cat();
                   break;
               case "dog": animal = new dog();
                   break;
           }
           return animal;
       }

   }
}
