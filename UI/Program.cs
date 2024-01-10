using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLogicLibrary;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate presentation object
            Presentation presentation = new Presentation();

            /* Call the PresentMenu function from the presentation object
               So that you could present the menu to the user */

            while (true)
            {
                presentation.PresentMenu();
                presentation.HandleMenuOption();
            }

        }
    }
}
